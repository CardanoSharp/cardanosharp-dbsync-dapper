using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.Reserve)]
    public partial class Reserve
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public int CertIndex { get; set; }
        public decimal Amount { get; set; }
        public long TxId { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual Tx Tx { get; set; }
    }
}
