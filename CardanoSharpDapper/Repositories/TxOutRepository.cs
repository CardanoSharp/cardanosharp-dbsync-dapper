using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxOutRepository : IGenericRepository<TxOut>
    {
    }
    public class TxOutRepository : GenericRepository<TxOut>, ITxOutRepository
    {
        public TxOutRepository(IDbConnection configuration)
            : base(configuration, TableNames.TxOut) { }
    }
}
