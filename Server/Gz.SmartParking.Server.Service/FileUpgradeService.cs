using System;
using System.Collections.Generic;
using System.Text;
using Gz.SmartParking.Server.ICommon;
using Gz.SmartParking.Server.IService;

namespace Gz.SmartParking.Server.Service
{
    public class FileUpgradeService : BaseService, IFileUpgradeService
    {
        public FileUpgradeService(IDbConnectionFactory contextFactor) : base(contextFactor)
        {

        }
    }
}
