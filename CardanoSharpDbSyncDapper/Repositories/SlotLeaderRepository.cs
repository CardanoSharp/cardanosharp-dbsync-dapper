using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISlotLeaderRepository : IGenericRepository<SlotLeader>
    {
    }
    public class SlotLeaderRepository : GenericRepository<SlotLeader>, ISlotLeaderRepository
    {
        public SlotLeaderRepository(IDbConnection configuration)
            : base(configuration, TableNames.SlotLeader) { }
    }
}
