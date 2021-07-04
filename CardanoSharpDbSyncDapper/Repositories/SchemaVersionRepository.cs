using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISchemaVersionRepository : IRepository<SchemaVersion>
    {
    }
    public class SchemaVersionRepository : Repository<SchemaVersion>, ISchemaVersionRepository
    {
        public SchemaVersionRepository(IConfiguration configuration)
            : base(configuration, TableNames.SchemaVersion) { }
    }
}
