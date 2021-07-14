using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IReserveRepository : IGenericRepository<Reserve>
    {
    }
    public class ReserveRepository : GenericRepository<Reserve>, IReserveRepository
    {
        public ReserveRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reserve) { }
    }
}
