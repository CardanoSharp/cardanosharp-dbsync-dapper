using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class OrphanRewardsMap : EntityMap<OrphanedReward>
    {
        public OrphanRewardsMap()
        {
            Map(p => p.Id).ToColumn("id");
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.Amount).ToColumn("amount");
            Map(p => p.EpochNo).ToColumn("epoch_no");
            Map(p => p.PoolId).ToColumn("pool_id");
            Map(p => p.BlockId).ToColumn("block_id");
        }
    }
}
