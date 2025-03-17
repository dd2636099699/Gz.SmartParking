using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gz.SmartParking.Server.EFCore
{
    /// <summary>
    /// 1.写一个类
    /// 2.实现IDesignTimeContextFactory接口
    /// 3.返回Dbcontext类就行了
    /// </summary>
    public class DbContextDesignTimeFactory : IDesignTimeDbContextFactory<EFCoreContext>
    {
        public EFCoreContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EFCoreContext> builder = new DbContextOptionsBuilder<EFCoreContext>();
            builder.UseSqlServer("Server=LAPTOP-7RAV79T8;Database=gz_sp;User ID=sa;Password=2636099699;TrustServerCertificate=True;");
            return new EFCoreContext(builder.Options);
        }
    }
}
