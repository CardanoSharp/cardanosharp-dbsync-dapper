using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxRepository : IGenericRepository<Tx>
    {
    }
    public class TxRepository : GenericRepository<Tx>, ITxRepository
    {
        public TxRepository(IDbConnection configuration)
            : base(configuration, TableNames.Tx) { }
    }
}