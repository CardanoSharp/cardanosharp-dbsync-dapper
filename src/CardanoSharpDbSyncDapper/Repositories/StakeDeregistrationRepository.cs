using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeDeregistrationRepository : IGenericRepository<StakeDeregistration>
    {
    }
    public class StakeDeregistrationRepository : GenericRepository<StakeDeregistration>, IStakeDeregistrationRepository
    {
        public StakeDeregistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeDeregistration) { }
    }
}
