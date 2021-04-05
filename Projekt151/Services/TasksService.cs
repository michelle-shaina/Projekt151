using Dapper;
using Microsoft.Data.SqlClient;
using Projekt151.Data;
using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public class TasksService : ITasksService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public TasksService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateTask(Tasks task)
        {
            bool IsDone = false;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Tasks (TaskName, Beschreibung, IsDone) values (@TaskName,  @Beschreibung, @IsDone)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { task.TaskName, task.Beschreibung, IsDone }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteTask(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Tasks where TaskId=@Id";
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

        public async Task<bool> EditTask(int id, Tasks task)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Tasks set TaskName = @TaskName, Beschreibung = @Beschreibung, IsDone = @IsDone where TaskId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { task.TaskName, task.Beschreibung, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<Tasks>> GetTasks()
        {
            IEnumerable<Tasks> task;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Tasks";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    task = await conn.QueryAsync<Tasks>(query);
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
            return task;
        }

        public async Task<Tasks> SingeleTask(int id)
        {
            Tasks task = new Tasks();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Tasks where TaskId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    task = await conn.QueryFirstOrDefaultAsync<Tasks>(query, new { id }, commandType: CommandType.Text);
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
            return task;
        }
    }
}