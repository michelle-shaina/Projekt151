﻿using Dapper;
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
    public class RoleService : IRoleService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public RoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> EditRole(int id, Role role)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"UPDATE [dbo].[Role] SET [RoleName] = @RoleName WHERE RoleId = @id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { role.RoleName, id }, commandType: CommandType.Text);
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

        public async Task<Role> SingleRole(int id)
        {
            Role role = new Role();
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Role where RoleId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    role = await conn.QueryFirstOrDefaultAsync<Role>(query, new { id }, commandType: CommandType.Text);
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
            return role;
        }
    }
}
