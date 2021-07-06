using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class DelegationMap : EntityMap<Delegation>
    {
        public DelegationMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.PoolHashId).ToColumn("pool_hash_id");
            Map(p => p.ActiveEpochNo).ToColumn("active_epoch_no");
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
