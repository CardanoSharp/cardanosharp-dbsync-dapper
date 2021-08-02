using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class MetumMap : EntityMap<Metum>
    {
        public MetumMap()
        {
            Map(p => p.StartTime).ToColumn("start_time");
            Map(p => p.NetworkName).ToColumn("network_name");
        }
    }
}
