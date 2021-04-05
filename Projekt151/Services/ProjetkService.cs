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
                const string query = @"delete from dbo.Projekt where ProjektId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
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

        public  async Task<bool> EditProject(int id, ProjektModel projekt)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Projekt set ProjektName = @ProjektName, Beschreibung = @Beschreibung, StartDate = @StartDate, EndDate = @EndDate, IsGoing = @IsGoing, KategorieId = @KategorieId, TaskId = @TaskId, MitarbeiterId = @MitarbeiterId where ProjektId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { projekt.ProjektName, projekt.Beschreibung, projekt.StartDate, projekt.EndDate, projekt.IsGoing, projekt.KategorieId, projekt.TaskId, projekt.MitarbeiterId, id }, commandType: CommandType.Text);
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
        public async Task<IEnumerable<ProjektModel>> GetProjects()
        {
            IEnumerable<ProjektModel> projekt;
            //List<ProjectFormatted> projects;
            List<Tasks> tasks = new List<Tasks>();
            List<Mitarbeiter> mitarbeiters = new List<Mitarbeiter>();
            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = @"SELECT Top (2000) Projekt.[ProjektId],Projekt.[ProjektName],Projekt.[Beschreibung],Projekt.[StartDate],Projekt.[EndDate],Projekt.[IsGoing],Projekt.[KategorieId],Projekt.[TaskId],Projekt.[MitarbeiterId],Mitarbeiter.MitarbeiterName,Kategorie.KategorieName,Tasks.TaskName FROM [Projekt151].[dbo].[Projekt] join dbo.ProjektToMitarbeiter on ProjektToMitarbeiter.ProjektId = Projekt.ProjektId join dbo.Mitarbeiter on ProjektToMitarbeiter.MitarbeiterId = Mitarbeiter.MitarbeiterId join dbo.Kategorie on Projekt.KategorieId = Kategorie.KategorieId join dbo.Tasks on Tasks.TaskId = Projekt.TaskId";
                string query1 = @"";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    projekt = await conn.QueryAsync<ProjektModel>(query);
                    var projects = await conn.QueryAsync<ProjectFormatted>(query);
                    
                    
                    //foreach (var p in projekt)
                    //{
                    //    if (p.ProjektId == id)
                    //    {
                    //        tasks.Add(new Tasks
                    //        {
                    //            TaskId = p.TaskId,
                    //            TaskName = p.TaskName
                    //        });
                    //        mitarbeiters.Add(new Mitarbeiter
                    //        {
                    //            MitarbeiterId = p.MitarbeiterId.ToString(),
                    //            MitarbeiterName = p.MitarbeiterName
                    //        });
                    //    }
                    //    else
                    //    {
                    //        id = p.ProjektId;
                    //        projects.Add(new ProjectFormatted
                    //        {
                    //            ProjektName = p.ProjektName,
                    //            Mitarbeiters = mitarbeiters,
                    //            Tasks = tasks
                    //        });
                    //    }
                    //}
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

        public async Task<ProjektModel> SingleProject(int id)
        {
            ProjektModel projekt = new ProjektModel();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Projekt where ProjektId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    projekt = await conn.QueryFirstOrDefaultAsync<ProjektModel>(query, new { id }, commandType: CommandType.Text);
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
