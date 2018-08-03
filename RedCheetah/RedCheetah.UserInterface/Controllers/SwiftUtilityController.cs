using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.Interface;

namespace RedCheetah.UserInterface.Controllers
{
    public class SwiftUtilityController : Controller
    {
        ISwiftUtility _switftSvc;

        public SwiftUtilityController(ISwiftUtility swiftSvc)
        {
            _switftSvc = swiftSvc;
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        // GET: SwiftUtility
        public JsonResult getMsisdn(long customerId)
        {
            return Json(new {data = _switftSvc.Msisdn(customerId) }, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult getAccountId(string accountName)
        {
            return Json(_switftSvc.AccountId(accountName), JsonRequestBehavior.AllowGet);
        }
    }
}