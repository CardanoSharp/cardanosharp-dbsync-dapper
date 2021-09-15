using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class StakeAddressMap : EntityMap<StakeAddress>
    {
        public StakeAddressMap()
        {
            Map(p => p.HashRaw).ToColumn("hash_raw");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
