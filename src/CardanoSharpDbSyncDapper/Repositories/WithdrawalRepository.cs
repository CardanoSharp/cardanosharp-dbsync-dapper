using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IWithdrawalRepository : IGenericRepository<Withdrawal>
    {
    }
    public class WithdrawalRepository : GenericRepository<Withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(IConfiguration configuration)
            : base(configuration, TableNames.Withdrawal) { }
    }
}
