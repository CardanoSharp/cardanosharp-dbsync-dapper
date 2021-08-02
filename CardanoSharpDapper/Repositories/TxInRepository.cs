using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxInRepository : IGenericRepository<TxIn>
    {
    }
    public class TxInRepository : GenericRepository<TxIn>, ITxInRepository
    {
        public TxInRepository(IDbConnection configuration)
            : base(configuration, TableNames.TxIn) { }
    }
}
