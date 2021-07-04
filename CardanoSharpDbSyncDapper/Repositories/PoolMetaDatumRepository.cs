using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolMetaDatumRepository : IRepository<PoolMetaDatum>
    {
    }
    public class PoolMetaDatumRepository : Repository<PoolMetaDatum>, IPoolMetaDatumRepository
    {
        public PoolMetaDatumRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolMetaDatum) { }
    }
}
