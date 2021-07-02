using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolOwnerMap : EntityMap<PoolOwner>
    {
        public PoolOwnerMap()
        {
            Map(p => p.PoolHashId).ToColumn("pool_hash_id");
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
