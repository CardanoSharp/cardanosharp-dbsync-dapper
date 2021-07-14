using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IDelegationRepository : IGenericRepository<Delegation>
    {
    }
    public class DelegationRepository : GenericRepository<Delegation>, IDelegationRepository
    {
        public DelegationRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.Delegation) { }
    }
}
