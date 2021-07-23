using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITreasuryRepository : IGenericRepository<Treasury>
    {
    }
    public class TreasuryRepository : GenericRepository<Treasury>, ITreasuryRepository
    {
        public TreasuryRepository(IDbConnection configuration)
            : base(configuration, TableNames.Treasury) { }
    }
}
