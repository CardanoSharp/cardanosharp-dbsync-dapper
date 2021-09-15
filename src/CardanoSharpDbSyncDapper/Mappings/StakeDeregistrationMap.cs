using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class StakeDeregistrationMap : EntityMap<StakeDeregistration>
    {
        public StakeDeregistrationMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
