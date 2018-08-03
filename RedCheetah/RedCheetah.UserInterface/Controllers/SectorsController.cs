using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.DB.REDCHEETAH.STAGING;
using RedCheetah.Core.Interface;
using RedCheetah.Core.Models;

namespace RedCheetah.UserInterface.Controllers
{
    public class SectorsController : Controller
    {
        private readonly RedCheetahStaging _db = new RedCheetahStaging();

        private readonly ISector _sectorSvc;

        public SectorsController(ISector sectorSvc)
        {
            _sectorSvc = sectorSvc;
        }


        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult UpdateSector(long sectorId, string sectorName)
        {
            if ((_sectorSvc.UpdateSector(sectorId, sectorName) == true))
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult CreateSector(string sectorName)
        {
            if (_sectorSvc.AddSector(sectorName) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);

        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult DeleteSector(long sectorId)
        {
            if (_sectorSvc.DeleteSector(sectorId) == true)
                return Json("Success", JsonRequestBehavior.AllowGet);

            return Json("Failure", JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetSectorFromId(long sectorId)
        {
            return Json(string.Format("{0}", _db.RC_SECTORS.Where(x => x.SECTOR_ID == sectorId).Select(x => x.SECTOR_NAME).FirstOrDefault()), JsonRequestBehavior.AllowGet);
        }


        // GET: Sectors
        public ActionResult AddNewSector()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult GetSectors()
        {
            var allsectors = _db.RC_SECTORS.Where(x=> !x.IsDelete == true).Select(x => new {
                SectorId = x.SECTOR_ID,
                SectorName = x.SECTOR_NAME
            }).ToList().OrderByDescending(x => x.SectorId);

            return Json(new {data = allsectors }, JsonRequestBehavior.AllowGet);
        }
    }
}