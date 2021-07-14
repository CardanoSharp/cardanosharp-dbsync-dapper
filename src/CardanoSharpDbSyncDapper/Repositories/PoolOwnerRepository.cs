using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolOwnerRepository : IGenericRepository<PoolOwner>
    {
    }
    public class PoolOwnerRepository : GenericRepository<PoolOwner>, IPoolOwnerRepository
    {
        public PoolOwnerRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolOwner) { }
    }
}
