using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxOutRepository : IRepository<TxOut>
    {
    }
    public class TxOutRepository : Repository<TxOut>, ITxOutRepository
    {
        public TxOutRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxOut) { }
    }
}
