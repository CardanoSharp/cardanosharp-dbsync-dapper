using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxMetadatumRepository : IGenericRepository<TxMetadatum>
    {
    }
    public class TxMetadatumRepository : GenericRepository<TxMetadatum>, ITxMetadatumRepository
    {
        public TxMetadatumRepository(IDbConnection configuration)
            : base(configuration, TableNames.TxMetadatum) { }
    }
}
