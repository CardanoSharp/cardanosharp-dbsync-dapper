using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolHashMap : EntityMap<PoolHash>
    {
        public PoolHashMap()
        {
            Map(p => p.HashRaw).ToColumn("hash_raw");
        }
    }
}
