using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeAddressRepository : IGenericRepository<StakeAddress>
    {
    }
    public class StakeAddressRepository : GenericRepository<StakeAddress>, IStakeAddressRepository
    {
        public StakeAddressRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeAddress) { }
    }
}
