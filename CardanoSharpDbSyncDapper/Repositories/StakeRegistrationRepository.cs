using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeRegistrationRepository : IRepository<StakeRegistration>
    {
    }
    public class StakeRegistrationRepository : Repository<StakeRegistration>, IStakeRegistrationRepository
    {
        public StakeRegistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeRegistration) { }
    }
}
