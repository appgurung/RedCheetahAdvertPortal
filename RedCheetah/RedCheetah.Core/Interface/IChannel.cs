using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCheetah.Core.Interface
{
    public interface IChannel
    {
        bool AddChannel(string channelName, int sectorId);

        bool UpdateChannel(long channelId, string channelName, long sectorId);

        bool DeleteChannel(long channelId);
    }
}
