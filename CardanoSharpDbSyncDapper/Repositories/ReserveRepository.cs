using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IReserveRepository : IRepository<Reserve>
    {
    }
    public class ReserveRepository : Repository<Reserve>, IReserveRepository
    {
        public ReserveRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reserve) { }
    }
}
