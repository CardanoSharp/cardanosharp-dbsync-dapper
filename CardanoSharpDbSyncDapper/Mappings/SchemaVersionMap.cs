using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class SchemaVersionMap : EntityMap<SchemaVersion>
    {
        public SchemaVersionMap()
        {
            Map(p => p.StageOne).ToColumn("stage_one");
            Map(p => p.StageTwo).ToColumn("stage_two");
            Map(p => p.StageThree).ToColumn("stage_three");
        }
    }
}
