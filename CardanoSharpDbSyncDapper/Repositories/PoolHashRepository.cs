using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolHashRepository : IRepository<PoolHash>
    {
    }
    public class PoolHashRepository : Repository<PoolHash>, IPoolHashRepository
    {
        public PoolHashRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolHash) { }
    }
}
