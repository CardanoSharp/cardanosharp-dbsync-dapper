using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolUpdateRepository : IRepository<PoolUpdate>
    {
    }
    public class PoolUpdateRepository : Repository<PoolUpdate>, IPoolUpdateRepository
    {
        public PoolUpdateRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolUpdate) { }
    }
}
