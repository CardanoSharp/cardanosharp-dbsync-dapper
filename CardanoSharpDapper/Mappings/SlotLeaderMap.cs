using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class SlotLeaderMap : EntityMap<SlotLeader>
    {
        public SlotLeaderMap()
        {
            Map(p => p.PoolHashId).ToColumn("pool_hash_id");
        }
    }
}
