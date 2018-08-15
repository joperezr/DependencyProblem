using FrameworkProject;
using System.Configuration;

namespace StandardProject
{
    public class SqlConnectionSettings : ISqlConnectionSettings
    {
        public ConnectionStringSettings ConnectionString => new ConnectionStringSettings(); 
    }
}
