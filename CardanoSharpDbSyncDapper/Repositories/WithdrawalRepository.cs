using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IWithdrawalRepository : IRepository<Withdrawal>
    {
    }
    public class WithdrawalRepository : Repository<Withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(IConfiguration configuration)
            : base(configuration, TableNames.Withdrawal) { }
    }
}
