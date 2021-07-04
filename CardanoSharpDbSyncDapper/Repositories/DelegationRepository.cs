using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IDelegationRepository : IRepository<Delegation>
    {
    }
    public class DelegationRepository : Repository<Delegation>, IDelegationRepository
    {
        public DelegationRepository(IConfiguration configuration)
            : base(configuration, TableNames.Delegation) { }
    }
}
