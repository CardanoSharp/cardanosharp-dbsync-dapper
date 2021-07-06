using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IUtxoViewRepository : IRepository<UtxoView>
    {
    }
    public class UtxoViewRepository : Repository<UtxoView>, IUtxoViewRepository
    {
        public UtxoViewRepository(IConfiguration configuration)
            : base(configuration, TableNames.UtxoView) { }
    }
}
