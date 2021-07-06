using CardanoSharp.DbSync.EntityFramework.Models;
using CardanoSharpDbSyncDapper.Common;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITxInRepository : IRepository<TxIn>
    {
    }
    public class TxInRepository : Repository<TxIn>, ITxInRepository
    {
        public TxInRepository(IConfiguration configuration)
            : base(configuration, TableNames.TxIn) { }
    }
}
