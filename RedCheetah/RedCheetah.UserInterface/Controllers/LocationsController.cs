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
    public class LocationsController : Controller
    {
        private readonly RedCheetahStaging _db = new RedCheetahStaging();

        private readonly ILocation _locationSvc;

        public LocationsController(ILocation locationSvc)
        {
            _locationSvc = locationSvc;
        }

        // GET: Locations
        public ActionResult AddNewLocation()
        {
            var availableChannels = _db.RC_CHANNELS.Where(x=> !x.IsDelete == true).Select(x => new {
                channelId = x.CHANNEL_ID,
                channelName = x.CHANNEL_NAME
            }).ToList();

            List<Channel> modemChannel = new List<Channel>();

            foreach(var availableChannel in availableChannels)
            {
                var channel = new Channel();

                channel.ChannelId = availableChannel.channelId;
                channel.ChannelName = availableChannel.channelName;

                modemChannel.Add(channel);
            }

            return View(modemChannel);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult CreateLocation(string LocatonName, int channelId)
        {
            if (_locationSvc.AddLocation(LocatonName, channelId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult UpdateLocation(long locationId, string locationName, long channelId)
        {
            if (_locationSvc.UpdateLocation(locationId, locationName, channelId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetLocationFromId(long locationId)
        {
            var location = _db.RC_LOCATIONS.Where(x => x.LOCATION_ID == locationId).Select(x => x).FirstOrDefault();

            var channel = _db.RC_CHANNELS.Where(x => x.CHANNEL_ID == location.CHANNEL_ID).Select(x => x).FirstOrDefault();

            object retVal = new {
                locationName = location.LOCATION_NAME,
                channelId = channel.CHANNEL_ID,
                channelName = channel.CHANNEL_NAME,
                channels = _db.RC_CHANNELS.Select(x => new { channelId = x.CHANNEL_ID, channelName = x.CHANNEL_NAME }).ToList()
            };

            return Json(retVal, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult DeleteLocation(long locationId)
        {
            if (_locationSvc.DeleteLocation(locationId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetLocations()
        {
            var allLocations = (from x in _db.RC_SECTORS where !x.IsDelete == true
                                join y in _db.RC_CHANNELS on x.SECTOR_ID equals y.SECTOR_ID where !y.IsDelete == true
                                join z in _db.RC_LOCATIONS on y.CHANNEL_ID equals z.CHANNEL_ID where !z.IsDelete == true
                                select new {
                                    LocationId = z.LOCATION_ID,
                                    LocationName = z.LOCATION_NAME,
                                    ChannelName = y.CHANNEL_NAME,
                                    SectorName = x.SECTOR_NAME
                                }).ToList().OrderByDescending(x => x.LocationId);

            return Json(new { data = allLocations}, JsonRequestBehavior.AllowGet);
                                
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetLocationFromChannelId(long channelId)
        {
            var locations = (from x in _db.RC_LOCATIONS
                             where !x.IsDelete == true && x.CHANNEL_ID == channelId
                             select new {
                                 locationId = x.LOCATION_ID,
                                 locationName = x.LOCATION_NAME,
                             }).ToList().OrderByDescending(x => x.locationId);

            return Json(new { data = locations }, JsonRequestBehavior.AllowGet);
        }
    }
}