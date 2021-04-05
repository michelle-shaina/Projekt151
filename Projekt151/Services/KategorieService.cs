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
    public class KategorieService : IKategorieService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public KategorieService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> CreateCategory(Kategorie kategorie)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"insert into dbo.Kategorie (KategorieName, Beschreibung) values (@KategorieName,  @Beschreibung)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { kategorie.KategorieName, kategorie.Beschreibung }, commandType: CommandType.Text);
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

            public async Task<bool> DeleteCategory(int id)
            {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"delete from dbo.Kategorie where KategorieId=@Id";
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

        public async Task<bool> EditCategory(int id, Kategorie kategorie)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"update dbo.Kategorie set KategorieName = @KategorieName, Beschreibung = @Beschreibung where KategorieId=@Id";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { kategorie.KategorieName, kategorie.Beschreibung, id }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<Kategorie>> GetCategories()
        {
            IEnumerable<Kategorie> kategorie;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Kategorie";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    kategorie = await conn.QueryAsync<Kategorie>(query);
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
            return kategorie;
        }

        public async Task<Kategorie> SingleCategory(int id)
        {
            Kategorie kategorie = new Kategorie();

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"select * from dbo.Kategorie where KategorieId=@Id";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    kategorie = await conn.QueryFirstOrDefaultAsync<Kategorie>(query, new { id }, commandType: CommandType.Text);
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
            return kategorie;
        }
    }
}
