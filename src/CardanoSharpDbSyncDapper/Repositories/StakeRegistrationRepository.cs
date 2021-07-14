using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeRegistrationRepository : IGenericRepository<StakeRegistration>
    {
    }
    public class StakeRegistrationRepository : GenericRepository<StakeRegistration>, IStakeRegistrationRepository
    {
        public StakeRegistrationRepository(IConfiguration configuration)
            : base(configuration, TableNames.StakeRegistration) { }
    }
}
