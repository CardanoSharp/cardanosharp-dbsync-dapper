using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxOutRepository : IGenericRepository<TxOut>
    {
    }
    public class TxOutRepository : GenericRepository<TxOut>, ITxOutRepository
    {
        public TxOutRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxOut) { }
    }
}
