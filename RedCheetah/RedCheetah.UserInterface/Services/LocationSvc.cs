using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Services
{
    public class LocationSvc : ILocation
    {

        private readonly RedCheetahStaging _db;

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LocationSvc));

        public LocationSvc(RedCheetahStaging db)
        {
            db = new RedCheetahStaging();
            _db = db;
        }

        public bool AddLocation(string LocatonName, int channelId)
        {
            try
            {

                RC_LOCATIONS channel = new RC_LOCATIONS()
                {
                    LOCATION_NAME = LocatonName,
                    CHANNEL_ID = channelId,
                    IsDelete = false,
                   // LOCATION_ID = _db.RC_LOCATIONS.Select(x=> x.CHANNEL_ID).Last() + 1 //remove in production
                };

                _db.RC_LOCATIONS.Add(channel);

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

        public bool UpdateLocation(long locationId, string locationName, long channelId)
        {
            try
            {
                RC_LOCATIONS location = _db.RC_LOCATIONS.Where(x => x.LOCATION_ID == locationId).Select(x => x).FirstOrDefault();

                location.LOCATION_NAME = locationName;

                location.CHANNEL_ID = (int)channelId;

                _db.Entry(location).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool DeleteLocation(long locationId)
        {
            try
            {
                RC_LOCATIONS location = _db.RC_LOCATIONS.Where(x => x.LOCATION_ID == locationId).Select(x => x).FirstOrDefault();

                //_db.RC_LOCATIONS.Remove(location);
                location.IsDelete = true;

                _db.Entry(location).State = System.Data.Entity.EntityState.Modified;

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