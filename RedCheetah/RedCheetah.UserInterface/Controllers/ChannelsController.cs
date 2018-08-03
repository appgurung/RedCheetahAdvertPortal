using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using log4net;
using RedCheetah.Core.Models;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Controllers
{
    public class ChannelsController : Controller
    {
        private readonly RedCheetahStaging _db = new RedCheetahStaging();

        private readonly IChannel _channelSvc;

        public ChannelsController(IChannel channelSvc)
        {
            _channelSvc = channelSvc;  
        }

        // GET: Channels
        public ActionResult AddNewChannel()
        {
            var availableSectors = _db.RC_SECTORS.Where(x=> !x.IsDelete == true).Select(x => new
            {
                sectorId = x.SECTOR_ID,
                sectorName = x.SECTOR_NAME
            }).ToList();

            List<Sector> modemSector = new List<Sector>();

            foreach(var availableSector in availableSectors)
            {
                var sector = new Sector();

                sector.SectorId = availableSector.sectorId;
                sector.SectorName = availableSector.sectorName;

                modemSector.Add(sector);
            }

            return View(modemSector);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult CreateChannel(string channelName, int sectorId)
        {
            if (_channelSvc.AddChannel(channelName, sectorId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult UpdateChannel(long channelId, string channelName, long sectorId)
        {
            if (_channelSvc.UpdateChannel(channelId, channelName, sectorId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetChannelFromId(long channelId)
        {
            var channel = _db.RC_CHANNELS.Where(x => x.CHANNEL_ID == channelId).Select(x => x).FirstOrDefault();
            var sector = _db.RC_SECTORS.Where(x => x.SECTOR_ID == channel.SECTOR_ID).Select(x => x).FirstOrDefault();

            dynamic retVal = new
            {
                channelName = channel.CHANNEL_NAME,
                sectorName = sector.SECTOR_NAME,
                sectorId = sector.SECTOR_ID,
                sectors = _db.RC_SECTORS.Select(x=> new {sectorId = x.SECTOR_ID, sectorName = x.SECTOR_NAME }).ToList()
            };

            return Json(retVal, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult DeleteChannel(long channelId)
        {
            if (_channelSvc.DeleteChannel(channelId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetChannels()
        {
            var allchannels = (from x in _db.RC_CHANNELS where !x.IsDelete == true
                                join y in _db.RC_SECTORS on x.SECTOR_ID equals y.SECTOR_ID where !y.IsDelete == true
                                select new {
                                    ChannelId = x.CHANNEL_ID,
                                    ChannelName = x.CHANNEL_NAME,
                                    SectorName = y.SECTOR_NAME
                                }).ToList().OrderByDescending(x=>x.ChannelId);
            return Json(new { data = allchannels}, JsonRequestBehavior.AllowGet);
        }
    }
}