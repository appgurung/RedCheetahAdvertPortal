using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Models;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Controllers
{
    public class ModemsController : Controller
    {
        private readonly RedCheetahStaging _db = new RedCheetahStaging();

        private readonly IModem _modemSvc;

        public ModemsController(IModem modemSvc)
        {
            _modemSvc = modemSvc;

        }

        // GET: Modem
        public ActionResult AddNewModem()
        {

            var availableSectors = _db.RC_SECTORS.Where(x => !x.IsDelete == true).Select(x => new
            {
                sectorId = x.SECTOR_ID,
                sectorName = x.SECTOR_NAME
            }).ToList();

            List<Sector> modemSector = new List<Sector>();

            foreach (var availableSector in availableSectors)
            {
                var sector = new Sector();

                sector.SectorId = availableSector.sectorId;
                sector.SectorName = availableSector.sectorName;

                modemSector.Add(sector);
            }

            ViewBag.Sectors = modemSector;


            var availableChannels = _db.RC_CHANNELS.Where(x => !x.IsDelete == true).Select(x => new {
                channelId = x.CHANNEL_ID,
                channelName = x.CHANNEL_NAME
            }).ToList();

            List<Channel> modemChannel = new List<Channel>();

            foreach (var availableChannel in availableChannels)
            {
                var channel = new Channel();

                channel.ChannelId = availableChannel.channelId;
                channel.ChannelName = availableChannel.channelName;

                modemChannel.Add(channel);
            }

            ViewBag.Channels = modemChannel;


            var availableLocations = _db.RC_LOCATIONS.Where(x=> !x.IsDelete == true).Select(x=> new {
                LocationsId = x.LOCATION_ID,
                LocationName = x.LOCATION_NAME
            }).ToList();

            List<Location> modemLoc = new List<Location>();

            foreach(var availableLoc in availableLocations)
            {
                var location = new Location();

                location.LocationId = availableLoc.LocationsId.ToString();
                location.LocationName = availableLoc.LocationName;

                modemLoc.Add(location);
            }

            return View(modemLoc);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult CreateModem(ModemDetails modemdetails)
        {
            if (_modemSvc.AddModem(modemdetails) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult UpdateModem(ModemDetails modemdetails, long modemId, long locationId)
        {
            if (_modemSvc.UpdateModem(modemdetails, modemId, locationId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetModemFromId(long modemId)
        {
            var modem = _db.RC_MODEMS.Where(x => x.MODEM_ID == modemId).Select(x => x).FirstOrDefault();

            var location = _db.RC_LOCATIONS.Where(x => x.LOCATION_ID == modem.LOCATION_ID).Select(x => x).FirstOrDefault();

            dynamic retVal = new
            {
                IpAddress = modem.IP_ADDRESS,
                modemId = modem.MODEM_ID,
                accountName = modem.ACCOUNT_NAME,
                customerId = modem.CUSTOMER_ID,
                accountId = modem.ACCOUNT_ID,
                locationName = location.LOCATION_NAME,
                IMSI = modem.IMSI,
                locationId = modem.LOCATION_ID,
                locations = _db.RC_LOCATIONS.Select(x => new { locationId = x.LOCATION_ID, locationName = x.LOCATION_NAME }).ToList()
            };

            return Json(retVal, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult DeleteModem(long modemId)
        {
            if (_modemSvc.DeleteModem(modemId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetModems()
        {
            var allModems = (from x in _db.RC_MODEMS where !x.IsDelete == true
                             join y in _db.RC_LOCATIONS on x.LOCATION_ID equals y.LOCATION_ID where !y.IsDelete == true
                             join z in _db.RC_CHANNELS on y.CHANNEL_ID equals z.CHANNEL_ID where !z.IsDelete == true
                             join a in _db.RC_SECTORS on z.SECTOR_ID equals a.SECTOR_ID where !a.IsDelete ==true
                             select new {
                                 ModemId = x.MODEM_ID,
                                 IpAddress = x.IP_ADDRESS,
                                 IMSI = x.IMSI,
                                 AccountName = x.ACCOUNT_NAME,
                                 LocationName = y.LOCATION_NAME,
                                 ChannelName = z.CHANNEL_NAME,
                                 SectorName = a.SECTOR_NAME
                             }).ToList().OrderByDescending(x => x.ModemId);

            return Json(new {data = allModems }, JsonRequestBehavior.AllowGet);
        }
    }
}