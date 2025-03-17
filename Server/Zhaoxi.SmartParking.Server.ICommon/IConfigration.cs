using System;
using System.Collections.Generic;
using System.Text;

namespace Gz.SmartParking.Server.ICommon
{
    public interface IConfigration
    {
        string Read(string key);
    }
}
