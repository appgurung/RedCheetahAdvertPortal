using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedCheetah.Core.Interface;
using RedCheetah.Core.DB.SWIFTUTILITY.STAGING;
using System.Collections;

namespace RedCheetah.UserInterface.Services
{
    public class SwiftUtilitySvc : ISwiftUtility
    {
        private readonly SwiftUtilityEntities _db;

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ChannelSvc));

        public SwiftUtilitySvc(SwiftUtilityEntities db)
        {
            db = new SwiftUtilityEntities();
            _db = db;
        }

        public IList Msisdn(long customerId)
        {
           try
            {

                return _db.SIMSInventories.Where(x => x.i_customer == customerId).Select(x => new {
                    PhoneNo = x.MSISDN
                }).ToList();

            }
            catch(Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return null;
        }

        public long AccountId(string accountName)
        {
           try
            {
                return _db.Accounts.Where(x => x.id == accountName).Select(x => x.i_account).FirstOrDefault();
            }
            catch(Exception ex)
            {
                _log.Error(ex.StackTrace);
            }
            return 0;
        }
    }
}