using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.ParamProposal)]
    public partial class ParamProposal
    {
        public long Id { get; set; }
        public int EpochNo { get; set; }
        public byte[] Key { get; set; }
        public int? MinFeeA { get; set; }
        public int? MinFeeB { get; set; }
        public int? MaxBlockSize { get; set; }
        public int? MaxTxSize { get; set; }
        public int? MaxBhSize { get; set; }
        public decimal? KeyDeposit { get; set; }
        public decimal? PoolDeposit { get; set; }
        public int? MaxEpoch { get; set; }
        public int? OptimalPoolCount { get; set; }
        public double? Influence { get; set; }
        public double? MonetaryExpandRate { get; set; }
        public double? TreasuryGrowthRate { get; set; }
        public double? Decentralisation { get; set; }
        public byte[] Entropy { get; set; }
        public int? ProtocolMajor { get; set; }
        public int? ProtocolMinor { get; set; }
        public decimal? MinUtxoValue { get; set; }
        public decimal? MinPoolCost { get; set; }
        public long RegisteredTxId { get; set; }

        public virtual Tx RegisteredTx { get; set; }
    }
}
