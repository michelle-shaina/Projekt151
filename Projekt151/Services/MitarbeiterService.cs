using Dapper;
using Microsoft.Data.SqlClient;
using Projekt151.Data;
using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public class MitarbeiterService : IMitarbeiterService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public MitarbeiterService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateEmployee(Mitarbeiter mitarbeiter)
        {
            if (mitarbeiter.Password == null || mitarbeiter.Password == String.Empty)
            {
                mitarbeiter.Password = "1234";
            }
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Mitarbeiter (MitarbeiterName, StadtId, Password, RoleId) values (@MitarbeiterName, @StadtId, @Password, @RoleId)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { mitarbeiter.MitarbeiterName, mitarbeiter.StadtId, mitarbeiter.Password, mitarbeiter.RoleId }, commandType: CommandType.Text);
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

        public async Task<bool> DeleteEmployee(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Mitarbeiter where MitarbeiterId=@Id";
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

        public async Task<bool> EditEmployee(int id, MitarbeiterModel mitarbeiter)
        {
            if (mitarbeiter.Password == null || mitarbeiter.Password == String.Empty)
            {
                mitarbeiter.Password = "1234";
            }
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Mitarbeiter set MitarbeiterName = @MitarbeiterName, StadtId = @StadtId, RoleId = @RoleId where MitarbeiterId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { mitarbeiter.MitarbeiterName, mitarbeiter.StadtId, mitarbeiter.RoleId, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<MitarbeiterModel>> GetEmployees()
        {
            IEnumerable<MitarbeiterModel> mitarbeiter;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select Mitarbeiter.MitarbeiterName, Stadt.StadtName as 'NameStadt', Stadt.StadtId, Role.RoleId, Role.RoleName, Mitarbeiter.MitarbeiterId, Mitarbeiter.Password from Mitarbeiter left join dbo.Stadt on Mitarbeiter.StadtId = Stadt.StadtId left join dbo.Role on Mitarbeiter.RoleId = Role.RoleId order by Mitarbeiter.MitarbeiterName";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    mitarbeiter = await conn.QueryAsync<MitarbeiterModel>(query);

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
            return mitarbeiter;
        }

        public async Task<MitarbeiterModel> SingleEmployee(int id)
        {
            MitarbeiterModel mitarbeiter = new MitarbeiterModel();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"SELECT TOP (1000) [MitarbeiterId],[MitarbeiterName],Stadt.StadtName as 'NameStadt',Mitarbeiter.[StadtId],[Password],[RoleId] FROM [Projekt151].[dbo].[Mitarbeiter] join dbo.Stadt on Mitarbeiter.StadtId = Stadt.StadtId where MitarbeiterId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    mitarbeiter = await conn.QueryFirstOrDefaultAsync<MitarbeiterModel>(query, new { id }, commandType: CommandType.Text);
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
            return mitarbeiter;
        }
    }
}
