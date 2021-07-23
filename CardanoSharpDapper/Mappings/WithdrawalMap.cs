using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class WithdrawalMap : EntityMap<Withdrawal>
    {
        public WithdrawalMap()
        {
            Map(p => p.AddrId).ToColumn("addr_id");
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
