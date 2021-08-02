using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class RewardMap : EntityMap<Reward>
    {
        public RewardMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.PoolId).ToColumn("pool_id");
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.BlockId).ToColumn("block_id");
        }
    }
}
