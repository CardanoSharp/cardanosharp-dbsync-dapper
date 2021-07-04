using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISlotLeaderRepository : IRepository<SlotLeader>
    {
    }
    public class SlotLeaderRepository : Repository<SlotLeader>, ISlotLeaderRepository
    {
        public SlotLeaderRepository(IConfiguration configuration)
            : base(configuration, TableNames.SlotLeader) { }
    }
}
