using Npgsql;
using System.Data;
using System.Data.Common;

namespace Application.Common
{
    public interface ICardanoDbConnection : IDbConnection
    { 
    }

    //public class CardanoDbConnection : DbConnection, ICardanoDbConnection
    //{
    //    public override string ConnectionString { get => base.ConnectionString; set => base.ConnectionString; }

    //    public override string Database => base.Database;

    //    public override string DataSource => base.DataSource;

    //    public override string ServerVersion => base.ServerVersion;

    //    public override ConnectionState State => base.State;

    //    public override void ChangeDatabase(string databaseName)
    //    {
    //        base.ChangeDatabase(databaseName);
    //    }

    //    public override void Close()
    //    {
    //        base.Close();
    //    }

    //    public override void Open()
    //    {
    //        base.Open();
    //    }

    //    protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
    //    {
    //        base.BeginDbTransaction(isolationLevel);
    //    }

    //    protected override DbCommand CreateDbCommand()
    //    {
    //        base.CreateDbCommand();
    //    }
    //}
}
