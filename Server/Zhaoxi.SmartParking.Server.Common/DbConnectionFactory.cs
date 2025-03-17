
using System;
using Gz.SmartParking.Server.EFCore;
using Gz.SmartParking.Server.ICommon;

namespace Gz.SmartParking.Server.Common
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        IConfigration _configuration;
        public DbConnectionFactory(IConfigration configuration)
        {
            _configuration = configuration;
        }

        public EFCoreContext CreateDbContext()
        {
            return new EFCoreContext(_configuration.Read("DbConnectStr"));// 只是针对SqlServer
        }
    }
}
