using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;

namespace RedCheetah.UserInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly RedCheetahStaging _db = new RedCheetahStaging();

        // GET: Home
        public ActionResult Dashboard()
        {
            ViewBag.AvailableSectors = _db.RC_SECTORS.Where(x=> !x.IsDelete == true).Count();
            ViewBag.AvailableChannels = _db.RC_CHANNELS.Where(x=> !x.IsDelete == true).Count();
            ViewBag.AvailbleLocations = _db.RC_LOCATIONS.Where(x=> !x.IsDelete == true).Count();
            ViewBag.AvailableModems = _db.RC_MODEMS.Where(x=> !x.IsDelete == true).Count();

            if (string.IsNullOrEmpty(Session["FLAG"] as string))
                ViewBag.Flag = null;
            else
                ViewBag.Flag = Session["FLAG"].ToString();

            return View();
        }

        public ActionResult LoadSectors()
        {

            Session["FLAG"] = "Sector";

            return RedirectToAction("Dashboard");
        }

        public ActionResult LoadChannels()
        {

            Session["FLAG"] = "Channel";

            return RedirectToAction("Dashboard");
        }

        public ActionResult LoadLocations()
        {

            Session["FLAG"] = "Location";

            return RedirectToAction("Dashboard");
        }

        public ActionResult LoadModems()
        {

            Session["FLAG"] = "Modem";

            return RedirectToAction("Dashboard");
        }
    }
}