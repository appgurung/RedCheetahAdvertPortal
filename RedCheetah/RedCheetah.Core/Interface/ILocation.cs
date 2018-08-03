using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCheetah.Core.Interface
{
    public interface ILocation
    {
        bool AddLocation(string LocatonName, int channelId);

        bool UpdateLocation(long locationId, string locationName, long channelId);

        bool DeleteLocation(long locationId);
    }
}
