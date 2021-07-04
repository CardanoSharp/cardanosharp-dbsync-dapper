namespace CardanoSharpDbSyncDapper.Common
{
    public static class TableNames
    {
        public const string Block = "block";
        public const string Delegation = "delegation";
        public const string Epoch = "epoch";
        public const string EpochParam = "epoch_param";
        public const string EpochStake = "epoch_stake";
        public const string MaTxMint = "ma_tx_mint";
        public const string MaTxOut = "ma_tx_out";
        public const string Metum = "meta";
        public const string ParamProposal = "param_proposal";
        public const string PoolHash = "pool_hash";
        public const string PoolMetaDatum = "pool_meta_data";
        public const string PoolOwner = "pool_owner";
        public const string PoolRelay = "pool_relay";
        public const string PoolRetire = "pool_retire";
        public const string PoolUpdate = "pool_update";
        public const string Reserve = "reserve";
        public const string Reward = "reward";
        public const string SchemaVersion = "schema_version";
        public const string SlotLeader = "slot_leader";
        public const string StakeAddress = "stake_address";
        public const string StakeDeregistration = "stake_deregistration";
        public const string StakeRegistration = "stake_registration";
        public const string Treasury = "treasury";
        public const string Tx = "tx";
        public const string TxIn = "tx_in";
        public const string TxMetadatum = "tx_metadata";
        public const string TxOut = "tx_out";
        public const string UtxoView = "utxo_view";
        public const string Withdrawal = "withdrawal";
        public const string OrphanedReward = "orphaned_reward";
    }
}