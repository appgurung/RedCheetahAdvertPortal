using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCheetah.Core.Interface
{
    public interface ISector
    {
         bool AddSector(string sectorName);

        bool UpdateSector(long sectorId, string sectorName);

        bool DeleteSector(long sectorId);



    }
}
