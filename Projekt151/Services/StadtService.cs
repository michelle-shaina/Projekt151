using Projekt151.Data;
using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Projekt151.Services
{
    public class StadtService : IStadtService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public StadtService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateCities(Stadt stadt)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Stadt (StadtName) values (@StadtName)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { stadt.StadtName }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteCity(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Stadt where StadtId=@Id";
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

        public async Task<bool> EditCity(int id, Stadt stadt)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Stadt set StadtName = @StadtName where StadtId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { stadt.StadtName, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<Stadt>> GetCities()
        {
            IEnumerable<Stadt> cities;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Stadt";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    cities = await conn.QueryAsync<Stadt>(query);

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
            return cities;
        }

        public async Task<Stadt> SingleCity(int id)
        {
            Stadt stadt = new Stadt();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Stadt where StadtId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    stadt = await conn.QueryFirstOrDefaultAsync<Stadt>(query, new { id }, commandType: CommandType.Text);
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
            return stadt;
        }
    }
}
