using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class QueryTest
    {
        private readonly string connectionString = "Data Source=localhost; Initial Catalog = cardano; User ID = sa; Password=!Password";
        protected IDbConnection GetConnection => new SqlConnection(connectionString);
        [Fact]
        public void GetBlockNumberAsync()
        {
            string _tableName = "block"; 
            using (var conn = GetConnection)
            {
                    conn.Open();
                    var result = conn.Query(
                        $"select * from {_tableName} where block_number = '2'",
                        new
                        {
                            TableName = _tableName,
                        });

                    Assert.Single(result.AsList()); 
            }

        }
    }
}
