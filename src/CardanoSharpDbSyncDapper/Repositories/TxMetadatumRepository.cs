using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxMetadatumRepository : IGenericRepository<TxMetadatum>
    {
    }
    public class TxMetadatumRepository : GenericRepository<TxMetadatum>, ITxMetadatumRepository
    {
        public TxMetadatumRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxMetadatum) { }
    }
}
