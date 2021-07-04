using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeDeregistrationRepository : IRepository<StakeDeregistration>
    {
    }
    public class StakeDeregistrationRepository : Repository<StakeDeregistration>, IStakeDeregistrationRepository
    {
        public StakeDeregistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeDeregistration) { }
    }
}
