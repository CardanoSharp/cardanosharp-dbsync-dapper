using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRetireRepository : IRepository<PoolRetire>
    {
    }
    public class PoolRetireRepository : Repository<PoolRetire>, IPoolRetireRepository
    {
        public PoolRetireRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRetire) { }
    }
}
