using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Services
{

    public class SectorSvc : ISector
    {
        private readonly RedCheetahStaging _db;

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(SectorSvc));

        public SectorSvc(RedCheetahStaging db)
        {
            db = new RedCheetahStaging();
            _db = db;
        }

        public bool AddSector(string sectorName)
        {
            try
            {
                RC_SECTORS sector = new RC_SECTORS()
                {
                    SECTOR_NAME = sectorName,
                    IsDelete = false,
                   // SECTOR_ID = _db.RC_SECTORS.Select(x=>x.SECTOR_ID).Last() + 1 //remove in production
                };

                _db.RC_SECTORS.Add(sector);

                _db.Entry(sector).State = System.Data.Entity.EntityState.Added;

                _db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool UpdateSector(long sectorId, string sectorName)
        {
            try
            {
                RC_SECTORS sector = _db.RC_SECTORS.Where(x => x.SECTOR_ID == sectorId).Select(x => x).FirstOrDefault();

                sector.SECTOR_NAME = sectorName;

                _db.Entry(sector).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                _log.Error(ex.StackTrace);
            }

            return false;
        }

        public bool DeleteSector(long sectorId)
        {
            try
            {
                RC_SECTORS sector = _db.RC_SECTORS.Where(x => x.SECTOR_ID == sectorId).Select(x => x).FirstOrDefault();

                //_db.RC_SECTORS.Remove(sector);
                sector.IsDelete = true;
                _db.Entry(sector).State = System.Data.Entity.EntityState.Modified;

                _db.SaveChanges();

                return true;

            }
            catch(Exception ex)
            {
                _log.ErrorFormat("Unable to delete for this reason:: {0}", ex.StackTrace);
            }

            return false;
        }

    }
}