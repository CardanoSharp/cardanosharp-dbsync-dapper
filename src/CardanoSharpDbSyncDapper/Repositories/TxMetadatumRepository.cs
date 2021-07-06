using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxMetadatumRepository : IRepository<TxMetadatum>
    {
    }
    public class TxMetadatumRepository : Repository<TxMetadatum>, ITxMetadatumRepository
    {
        public TxMetadatumRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxMetadatum) { }
    }
}
