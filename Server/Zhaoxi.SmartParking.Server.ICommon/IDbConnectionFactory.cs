using System;
using Gz.SmartParking.Server.EFCore;

namespace Gz.SmartParking.Server.ICommon
{
    public interface IDbConnectionFactory
    {
        EFCoreContext CreateDbContext();
    }
}
