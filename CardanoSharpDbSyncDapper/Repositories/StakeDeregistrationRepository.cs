using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeDeregistrationRepository : IGenericRepository<StakeDeregistration>
    {
    }
    public class StakeDeregistrationRepository : GenericRepository<StakeDeregistration>, IStakeDeregistrationRepository
    {
        public StakeDeregistrationRepository(IDbConnection configuration)
            : base(configuration, TableNames.StakeDeregistration) { }
    }
}
