using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISchemaVersionRepository : IGenericRepository<SchemaVersion>
    {
    }
    public class SchemaVersionRepository : GenericRepository<SchemaVersion>, ISchemaVersionRepository
    {
        public SchemaVersionRepository(IConfiguration configuration)
            : base(configuration, TableNames.SchemaVersion) { }
    }
}
