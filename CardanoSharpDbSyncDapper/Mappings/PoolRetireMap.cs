using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolRetireMap : EntityMap<PoolRetire>
    {
        public PoolRetireMap()
        {
            Map(p => p.HashId).ToColumn("hash_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.AnnouncedTxId).ToColumn("announced_tx_id");
            Map(p => p.RetiringEpoch).ToColumn("retiring_epoch");
        }
    }
}
