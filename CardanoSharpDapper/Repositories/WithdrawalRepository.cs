using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IWithdrawalRepository : IGenericRepository<Withdrawal>
    {
    }
    public class WithdrawalRepository : GenericRepository<Withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(IDbConnection configuration)
            : base(configuration, TableNames.Withdrawal) { }
    }
}
