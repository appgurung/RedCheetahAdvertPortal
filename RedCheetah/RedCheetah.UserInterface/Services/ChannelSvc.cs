using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using RedCheetah.Core.DB;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Services
{
    public class ChannelSvc : IChannel
    {

        private readonly RedCheetahStaging _db;

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ChannelSvc));

        public ChannelSvc(RedCheetahStaging db)
        {
            db = new RedCheetahStaging();
            _db = db;
        }

        public bool AddChannel(string channelName, int sectorId)
        {
            try
            {
                RC_CHANNELS channel = new RC_CHANNELS()
                {
                    CHANNEL_NAME = channelName,
                    SECTOR_ID = sectorId,
                    IsDelete = false,
                    //CHANNEL_ID = _db.RC_CHANNELS.Count() + 1 //remove in production
                };

                _db.RC_CHANNELS.Add(channel);

                _db.Entry(channel).State = System.Data.Entity.EntityState.Added;

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool UpdateChannel(long channelId, string channelName, long sectorId)
        {
            try
            {
                RC_CHANNELS channel = _db.RC_CHANNELS.Where(x => x.CHANNEL_ID == channelId).Select(x => x).FirstOrDefault();

                channel.CHANNEL_NAME = channelName;

                channel.SECTOR_ID = (int)sectorId;

                _db.Entry(channel).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool DeleteChannel(long channelId)
        {
            try
            {
                RC_CHANNELS channel = _db.RC_CHANNELS.Where(x => x.CHANNEL_ID == channelId).Select(x => x).FirstOrDefault();

                // _db.RC_CHANNELS.Remove(channel);
                channel.IsDelete = true;
                _db.Entry(channel).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                _log.ErrorFormat("Unable to delete for this reason:: {0}", ex.StackTrace);
            }

            return false;
        }

    }
}