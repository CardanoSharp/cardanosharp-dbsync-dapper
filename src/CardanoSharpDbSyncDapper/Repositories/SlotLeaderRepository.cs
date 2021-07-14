using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISlotLeaderRepository : IGenericRepository<SlotLeader>
    {
    }
    public class SlotLeaderRepository : GenericRepository<SlotLeader>, ISlotLeaderRepository
    {
        public SlotLeaderRepository(IConfiguration configuration)
            : base(configuration, TableNames.SlotLeader) { }
    }
}
