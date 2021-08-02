using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class TreasuryMap : EntityMap<Treasury>
    {
        public TreasuryMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.CertIndex).ToColumn("cert_index");
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
