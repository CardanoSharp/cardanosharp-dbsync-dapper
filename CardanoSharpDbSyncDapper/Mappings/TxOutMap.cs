using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class TxOutMap : EntityMap<TxOut>
    {
        public TxOutMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
            Map(p => p.AddressRaw).ToColumn("address_raw");
            Map(p => p.PaymentCred).ToColumn("payment_cred");
            Map(p => p.StakeAddressId).ToColumn("stake_address_id");
        }
    }
}
