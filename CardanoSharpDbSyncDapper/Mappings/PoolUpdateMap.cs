using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolUpdateMap : EntityMap<PoolUpdate>
    {
        public PoolUpdateMap()
        {
            Map(p => p.HashId).ToColumn("hash_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.VrfKeyHash).ToColumn("vrf_key_hash");
            Map(p => p.ActiveEpochNo).ToColumn("active_epoch_no");
            Map(p => p.MetaId).ToColumn("meta_id");
            Map(p => p.FixedCost).ToColumn("fixed_cost");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
            Map(p => p.RewardAddr).ToColumn("reward_addr");
        }
    }
}
