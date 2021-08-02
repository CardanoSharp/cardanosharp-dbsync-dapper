using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ISchemaVersionRepository : IGenericRepository<SchemaVersion>
    {
    }
    public class SchemaVersionRepository : GenericRepository<SchemaVersion>, ISchemaVersionRepository
    {
        public SchemaVersionRepository(IDbConnection configuration)
            : base(configuration, TableNames.SchemaVersion) { }
    }
}
