using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class PoolRelayMap : EntityMap<PoolRelay>
    {
        public PoolRelayMap()
        {
            Map(p => p.UpdateId).ToColumn("update_id");
            Map(p => p.DnsName).ToColumn("dns_name");
            Map(p => p.DnsSrvName).ToColumn("dns_srv_name");
        }
    }
}
