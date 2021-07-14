using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxInRepository : IGenericRepository<TxIn>
    {
    }
    public class TxInRepository : GenericRepository<TxIn>, ITxInRepository
    {
        public TxInRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxIn) { }
    }
}
