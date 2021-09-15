using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMetumRepository : IGenericRepository<Metum>
    {
    }
    public class MetumRepository : GenericRepository<Metum>, IMetumRepository
    {
        public MetumRepository(IDbConnection configuration)
            : base(configuration, TableNames.Metum) { }
    }
}
