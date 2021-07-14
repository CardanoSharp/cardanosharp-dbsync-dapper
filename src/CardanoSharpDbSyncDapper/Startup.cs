using Application.Common;
using CardanoSharpDbSyncDapper.Mappings;
using CardanoSharpDbSyncDapper.Repositories;
using Dapper.FluentMap;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using System.Data;

namespace CardanoSharpDbSyncDapper
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {            
            // Read the connection string from appsettings.
            string dbConnectionString = this.Configuration.GetConnectionString("CardanoDbSync");
            // Inject IDbConnection, with implementation from SqlConnection class.
            services.AddTransient<IDbConnection>((sp) => new NpgsqlConnection(dbConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });


            IBlockRepository yeet = new BlockRepository(Configuration);

            var result = yeet.GetByIdAsync(27647).Result; 

        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

    }
}
