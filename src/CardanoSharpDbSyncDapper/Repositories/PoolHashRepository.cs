using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolHashRepository : IGenericRepository<PoolHash>
    {
    }
    public class PoolHashRepository : GenericRepository<PoolHash>, IPoolHashRepository
    {
        public PoolHashRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolHash) { }
    }
}
