using CardanoSharpDbSyncDapper.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.PoolHash)]
    public partial class PoolHash
    {
        public PoolHash()
        {
            Delegations = new HashSet<Delegation>();
            EpochStakes = new HashSet<EpochStake>();
            OrphanedRewards = new HashSet<OrphanedReward>();
            PoolOwners = new HashSet<PoolOwner>();
            PoolRetires = new HashSet<PoolRetire>();
            PoolUpdates = new HashSet<PoolUpdate>();
            Rewards = new HashSet<Reward>();
            SlotLeaders = new HashSet<SlotLeader>();
        }

        public long Id { get; set; }
        public byte[] HashRaw { get; set; }
        public string View { get; set; }

        public virtual ICollection<Delegation> Delegations { get; set; }
        public virtual ICollection<EpochStake> EpochStakes { get; set; }
        public virtual ICollection<OrphanedReward> OrphanedRewards { get; set; }
        public virtual ICollection<PoolOwner> PoolOwners { get; set; }
        public virtual ICollection<PoolRetire> PoolRetires { get; set; }
        public virtual ICollection<PoolUpdate> PoolUpdates { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<SlotLeader> SlotLeaders { get; set; }
    }
}
