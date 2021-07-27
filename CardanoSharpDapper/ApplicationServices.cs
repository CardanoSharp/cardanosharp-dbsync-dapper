using CardanoSharpDbSyncDapper.Mappings;
using Dapper.FluentMap;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Microsoft.Extensions.DependencyInjection; 

namespace Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Read the connection string from appsettings.
            string dbConnectionString = configuration.GetConnectionString("CardanoDbSync");
            // Inject IDbConnection, with implementation from SqlConnection class.
            services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection(dbConnectionString));
            
            FluentMapper.Initialize(c =>
                {
                    c.AddMap(new BlockMap());
                    c.AddMap(new DelegationMap());
                    c.AddMap(new EpochMap());
                    c.AddMap(new EpochParamMap());
                    c.AddMap(new EpochStakeMap());
                    c.AddMap(new MaTxMintMap());
                    c.AddMap(new MaTxOutMap());
                    c.AddMap(new MetumMap());
                    c.AddMap(new ParamProposalMap());
                    c.AddMap(new PoolHashMap());
                    c.AddMap(new PoolMetaDatumMap());
                    c.AddMap(new PoolOwnerMap());
                    c.AddMap(new PoolRelayMap());
                    c.AddMap(new PoolRetireMap());
                    c.AddMap(new PoolUpdateMap());
                    c.AddMap(new ReserveMap());
                    c.AddMap(new RewardMap());
                    c.AddMap(new SchemaVersionMap());
                    c.AddMap(new SlotLeaderMap());
                    c.AddMap(new StakeAddressMap());
                    c.AddMap(new StakeRegistrationMap());
                    c.AddMap(new StakeDeregistrationMap());
                    c.AddMap(new TreasuryMap());
                    c.AddMap(new TxMap());
                    c.AddMap(new TxInMap());
                    c.AddMap(new TxOutMap());
                    c.AddMap(new TxMetadatumMap());
                    c.AddMap(new UtxoViewMap());
                    c.AddMap(new WithdrawalMap());
                });

            return services;
        }
    }
}
