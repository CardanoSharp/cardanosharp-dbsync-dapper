using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.MaTxOut)]
    public partial class MaTxOut
    {
        public long Id { get; set; }
        public byte[] Policy { get; set; }
        public byte[] Name { get; set; }
        public decimal Quantity { get; set; }
        public long TxOutId { get; set; }

        public virtual TxOut TxOut { get; set; }
    }
}
