using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeRegistrationRepository : IGenericRepository<StakeRegistration>
    {
    }
    public class StakeRegistrationRepository : GenericRepository<StakeRegistration>, IStakeRegistrationRepository
    {
        public StakeRegistrationRepository(IDbConnection configuration)
            : base(configuration, TableNames.StakeRegistration) { }
    }
}
