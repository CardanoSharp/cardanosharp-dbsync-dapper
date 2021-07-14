using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IUtxoViewRepository : IGenericRepository<UtxoView>
    {
    }
    public class UtxoViewRepository : GenericRepository<UtxoView>, IUtxoViewRepository
    {
        public UtxoViewRepository(IConfiguration configuration)
            : base(configuration, TableNames.UtxoView) { }
    }
}
