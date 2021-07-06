using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeAddressRepository : IRepository<StakeAddress>
    {
    }
    public class StakeAddressRepository : Repository<StakeAddress>, IStakeAddressRepository
    {
        public StakeAddressRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeAddress) { }
    }
}
