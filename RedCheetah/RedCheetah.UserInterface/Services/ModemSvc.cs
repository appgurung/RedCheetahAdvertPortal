using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Interface;
using RedCheetah.Core.Models;

namespace RedCheetah.UserInterface.Services
{
    public class ModemSvc : IModem
    {
 

        private readonly RedCheetahStaging _db;

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ModemSvc));

        public ModemSvc(RedCheetahStaging db)
        {
            db = new RedCheetahStaging();
            _db = db;
        }

        public bool AddModem(ModemDetails modemdetails)
        {
            try
            {
                RC_MODEMS modem = new RC_MODEMS()
                {
                   ACCOUNT_ID = modemdetails.AccountId,
                   ACCOUNT_NAME = modemdetails.AccountName,
                   CUSTOMER_ID = modemdetails.CustomerId,
                   IMSI = modemdetails.IMSI,
                   IP_ADDRESS = modemdetails.IpAddres,
                   LOCATION_ID = modemdetails.LocationId,
                   IsDelete = false,
                  // MODEM_ID = _db.RC_MODEMS.Select(x=>x.MODEM_ID).Last() + 1 //remove in production
                };

                _db.RC_MODEMS.Add(modem);

                _db.Entry(modem).State = System.Data.Entity.EntityState.Added;

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool UpdateModem(ModemDetails modemdetails, long modemId, long locationId)
        {
            try
            {
                RC_MODEMS modem = _db.RC_MODEMS.Where(x => x.MODEM_ID == modemId).Select(x => x).FirstOrDefault();

                modem.IP_ADDRESS = modemdetails.IpAddres;

                modem.IMSI = modemdetails.IMSI;

                modem.CUSTOMER_ID = modemdetails.CustomerId;

                modem.LOCATION_ID = (int)locationId;

                modem.LOCATION_ID = modemdetails.LocationId;

                modem.ACCOUNT_NAME = modemdetails.AccountName;

                _db.Entry(modem).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool DeleteModem(long modemId)
        {
            try
            {
                RC_MODEMS modem = _db.RC_MODEMS.Where(x => x.MODEM_ID == modemId).Select(x => x).FirstOrDefault();

                //_db.RC_MODEMS.Remove(modem);
                modem.IsDelete = true;

                _db.Entry(modem).State = System.Data.Entity.EntityState.Modified;

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