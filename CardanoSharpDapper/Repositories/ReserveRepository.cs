using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IReserveRepository : IGenericRepository<Reserve>
    {
    }
    public class ReserveRepository : GenericRepository<Reserve>, IReserveRepository
    {
        public ReserveRepository(IDbConnection configuration)
            : base(configuration, TableNames.Reserve) { }
    }
}
