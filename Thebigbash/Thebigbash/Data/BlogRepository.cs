using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Thebigbash.Models;
using Microsoft.Extensions.Configuration;

namespace Thebigbash.Data
{
    public class BlogRepository : IBlogRepository
    {
        private readonly string _connectionString;

        public BlogRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Blog>> GetAllBlogs()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Blogs";
                var blogs = await connection.QueryAsync<Blog>(sql);
                return blogs;
            }
        }
    }
}
