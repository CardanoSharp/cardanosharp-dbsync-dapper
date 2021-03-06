using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.MaTxMint)]
    public partial class MaTxMint
    {
        public long Id { get; set; }
        public byte[] Policy { get; set; }
        public byte[] Name { get; set; }
        public decimal Quantity { get; set; }
        public long TxId { get; set; }

        public virtual Tx Tx { get; set; }
    }
}
