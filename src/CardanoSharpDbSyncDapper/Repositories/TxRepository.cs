using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxRepository : IGenericRepository<Tx>
    {
        Task<Tx> GetByHashStrAsync(string hashStr);
    }
    public class TxRepository : GenericRepository<Tx>, ITxRepository
    {
        public TxRepository(IConfiguration configuration)
            : base(configuration, TableNames.Tx) { }

        public async Task<Tx> GetByHashStrAsync(string hashStr)
        {
            using (var conn = GetConnection)
            {
                try
                {
                    conn.Open();
                    return await conn.QueryFirstOrDefaultAsync<Tx>(
                        $"select * from {_tableName} where encode(hash, 'hex') = @HashStr",
                        new
                        {
                            HashStr = hashStr
                        });
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
            }
        }
    }
}