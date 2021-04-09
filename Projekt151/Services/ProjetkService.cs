using Microsoft.Data.SqlClient;
using Projekt151.Data;
using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace Projekt151.Services
{
    public class ProjetkService : IProjektService
    { 
        private readonly SqlConnectionConfiguration _configuration;
        public ProjetkService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateProjects(ProjectFormatted projekt)
        {
            IDictionary<string, object> lastSelectedProject;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Projekt (ProjektName, Beschreibung, StartDate, EndDate, IsGoing, KategorieId) values (@ProjektName, @Beschreibung, @StartDate, @EndDate, @IsGoing, @KategorieId)";
                const string getLastProject = @"SELECT top 1 Projekt.ProjektId FROM dbo.Projekt ORDER BY ProjektId DESC";
                const string addTasksToProjectQuery = @"INSERT INTO [dbo].[ProjektToTask]([ProjektId],[TaskId]) VALUES (@ProjektId,@TaskId)";
                const string addMitarbeiterToProjectQuery = @"INSERT INTO [dbo].[ProjektToMitarbeiter]([ProjektId],[MitarbeiterId]) VALUES (@ProjektId,@MitarbeiterId)";
                int ProjektId;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { projekt.ProjektName, projekt.Beschreibung, projekt.StartDate, projekt.EndDate, projekt.IsGoing, projekt.KategorieId }, commandType: CommandType.Text);
                    lastSelectedProject = conn.QueryFirstOrDefault(getLastProject);
                    var lastId = lastSelectedProject.Values.ToArray();
                    ProjektId = Convert.ToInt32(lastId[0]);
                    foreach (var t in projekt.Tasks)
                    {
                        await conn.ExecuteAsync(addTasksToProjectQuery, new { ProjektId, t.TaskId }, commandType: CommandType.Text);
                    }
                    foreach (var m in projekt.Mitarbeiters)
                    {
                        await conn.ExecuteAsync(addMitarbeiterToProjectQuery, new { ProjektId, m.MitarbeiterId }, commandType: CommandType.Text);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<bool> DelteProject(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string deleteTasks = @"DELETE from dbo.ProjektToTask where ProjektId = @id";
                const string deleteMitarbetier = @"DELETE FROM [dbo].[ProjektToMitarbeiter] WHERE ProjektId = @id";
                const string query = @"delete from dbo.Projekt where ProjektId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(deleteTasks, new { id });
                    await conn.ExecuteAsync(deleteMitarbetier, new { id });
                    await conn.ExecuteAsync(query, new { id }, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public  async Task<bool> EditProject(int id, ProjectFormatted projekt)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Projekt set ProjektName = @ProjektName, Beschreibung = @Beschreibung, StartDate = @StartDate, EndDate = @EndDate, IsGoing = @IsGoing, KategorieId = @KategorieId where ProjektId=@id";
                const string deleteTasks = @"DELETE from dbo.ProjektToTask where ProjektId = @id";
                const string deleteMitarbetier = @"DELETE FROM [dbo].[ProjektToMitarbeiter] WHERE ProjektId = @id";
                const string insertMitarbeiter = @"INSERT INTO [dbo].[ProjektToMitarbeiter]([ProjektId],[MitarbeiterId]) VALUES (@id, @MitarbeiterId)";
                const string insertTask = @"INSERT INTO [dbo].[ProjektToTask] ([ProjektId],[TaskId]) VALUES (@id, @TaskId)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(deleteTasks, new { id });
                    await conn.ExecuteAsync(deleteMitarbetier, new { id });
                    await conn.ExecuteAsync(query, new { projekt.ProjektName, projekt.Beschreibung, projekt.StartDate, projekt.EndDate, projekt.IsGoing, projekt.KategorieId, projekt.TaskId, projekt.MitarbeiterId, id }, commandType: CommandType.Text);
                    foreach (var m in projekt.Mitarbeiters)
                    {
                        await conn.ExecuteAsync(insertMitarbeiter, new { id, m.MitarbeiterId });
                    }
                    foreach (var t in projekt.Tasks)
                    {
                        await conn.ExecuteAsync(insertTask, new { id, t.TaskId });
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return true;
        }

        public async Task<IEnumerable<ProjectFormatted>> GetP()
        {
            List<ProjectFormatted> pro = new List<ProjectFormatted>();
            IEnumerable<Projekt> projekt;
            IEnumerable<Tasks> tasks;
            IEnumerable<Mitarbeiter> mitarbeiters;
            string proQuery = @"SELECT TOP (1000) [ProjektId],[ProjektName],[Beschreibung],[StartDate],[EndDate],[IsGoing],[KategorieId] FROM [Projekt151].[dbo].[Projekt]";
            string mitarbeiterQuery = @"Select Top (1000) ProjektToMitarbeiter.MitarbeiterId, ProjektToMitarbeiter.ProjektId, Mitarbeiter.MitarbeiterId, Mitarbeiter.MitarbeiterName from ProjektToMitarbeiter join dbo.Mitarbeiter on ProjektToMitarbeiter.MitarbeiterId = Mitarbeiter.MitarbeiterId where ProjektToMitarbeiter.ProjektId = @ProjektId";
            string taskQuery = @"Select Top (1000) ProjektToTask.TaskId, ProjektToTask.ProjektId, Tasks.TaskName, Tasks.TaskId, Tasks.Beschreibung from ProjektToTask join dbo.Tasks on ProjektToTask.TaskId = Tasks.TaskId where ProjektToTask.ProjektId = @ProjektId";
            using (var conn = new SqlConnection(_configuration.Value))
            {
                projekt = await conn.QueryAsync<Projekt>(proQuery);
                foreach (var p in projekt)
                {
                        tasks = await conn.QueryAsync<Tasks>(taskQuery, new { p.ProjektId });
                        mitarbeiters = await conn.QueryAsync<Mitarbeiter>(mitarbeiterQuery, new { p.ProjektId });
                        pro.Add(new ProjectFormatted
                        {
                            ProjektId = p.ProjektId,
                            Beschreibung = p.Beschreibung,
                            EndDate = p.EndDate,
                            IsGoing = p.IsGoing,
                            KategorieId = p.KategorieId.ToString(),
                            MitarbeiterId = p.MitarbeiterId.ToString(),
                            Mitarbeiters = mitarbeiters,
                            ProjektName = p.ProjektName,
                            StartDate = p.StartDate,
                            TaskId = null,
                            Tasks = tasks
                        });
                    }
                }
            return (IEnumerable<ProjectFormatted>)pro;
        }

        public async Task<ProjectFormatted> SingleProject(int id)
        {
            IEnumerable<Tasks> tasks;
            IEnumerable<Mitarbeiter> mitarbeiters;
            ProjectFormatted projekt = new ProjectFormatted();
            string mitarbeiterQuery = @"Select Top (1000) ProjektToMitarbeiter.MitarbeiterId, ProjektToMitarbeiter.ProjektId, Mitarbeiter.MitarbeiterId, Mitarbeiter.MitarbeiterName from ProjektToMitarbeiter join dbo.Mitarbeiter on ProjektToMitarbeiter.MitarbeiterId = Mitarbeiter.MitarbeiterId where ProjektToMitarbeiter.ProjektId = @id";
            string taskQuery = @"Select Top (1000) ProjektToTask.TaskId, ProjektToTask.ProjektId, Tasks.TaskName, Tasks.TaskId, Tasks.Beschreibung from ProjektToTask join dbo.Tasks on ProjektToTask.TaskId = Tasks.TaskId where ProjektToTask.ProjektId = @id";

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Projekt where ProjektId=@id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    tasks = await conn.QueryAsync<Tasks>(taskQuery, new { id });
                    mitarbeiters = await conn.QueryAsync<Mitarbeiter>(mitarbeiterQuery, new { id });
                    projekt = await conn.QueryFirstOrDefaultAsync<ProjectFormatted>(query, new { id }, commandType: CommandType.Text);
                    projekt.Tasks = tasks;
                    projekt.Mitarbeiters = mitarbeiters;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return projekt;
        }
    }
}
