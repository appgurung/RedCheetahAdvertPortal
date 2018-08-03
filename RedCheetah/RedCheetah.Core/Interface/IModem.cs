using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedCheetah.Core.Models;

namespace RedCheetah.Core.Interface
{
    public interface IModem
    {
        bool AddModem(ModemDetails modemdetails);

        bool UpdateModem(ModemDetails modemdetails, long modemId, long locationId);

        bool DeleteModem(long modemId);


    }
}
