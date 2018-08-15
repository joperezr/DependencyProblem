using System.Configuration;

namespace FrameworkProject
{
    public interface ISqlConnectionSettings
    {
        ConnectionStringSettings ConnectionString { get; }
    }
}
