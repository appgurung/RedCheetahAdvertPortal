using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCheetah.Core.Interface
{
    public interface IActiveDirectory
    {
        bool IsAuthenticated(string srvr, string usr, string pwd);
    }
}
