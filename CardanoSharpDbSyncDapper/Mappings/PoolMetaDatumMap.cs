using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolMetaDatumMap : EntityMap<PoolMetaDatum>
    {
        public PoolMetaDatumMap()
        {
            Map(p => p.RegisteredTxId).ToColumn("registered_tx_id");
        }
    }
}
