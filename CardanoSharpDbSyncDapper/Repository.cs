using Application.Common;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Application
{
    public interface IRepository
    {
    }

    public abstract class Repository: IRepository
    {
        private IDbConnection _connection;
        protected IDbConnection GetConnection
        {
            get
            {
                if (_connection.State != ConnectionState.Open) _connection.Open();
                return _connection;
            }
        }

        public Repository(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}
