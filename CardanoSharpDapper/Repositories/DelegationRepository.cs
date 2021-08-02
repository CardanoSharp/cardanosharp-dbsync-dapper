using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IDelegationRepository : IGenericRepository<Delegation>
    {
    }
    public class DelegationRepository : GenericRepository<Delegation>, IDelegationRepository
    {
        public DelegationRepository(IDbConnection configuration)
            : base(configuration, TableNames.Delegation) { }
    }
}
