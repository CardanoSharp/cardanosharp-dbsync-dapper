using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IUtxoViewRepository : IGenericRepository<UtxoView>
    {
    }
    public class UtxoViewRepository : GenericRepository<UtxoView>, IUtxoViewRepository
    {
        public UtxoViewRepository(IDbConnection configuration)
            : base(configuration, TableNames.UtxoView) { }
    }
}
