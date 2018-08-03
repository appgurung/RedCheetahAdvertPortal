using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedCheetah.Core.Interface;
using RedCheetah.UserInterface.Services;
namespace RedCheetah.UserInterface.Controllers
{
    public class AccountController : Controller
    {
        private static readonly string srvr = "";

        private readonly IActiveDirectory _ad;

        public AccountController(IActiveDirectory ad)
        {
            _ad = ad;
        }

        public ActionResult Login()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public JsonResult ValidateLoginCredentials(string user, string pwd)
        {
            try
            {
                var resp = false;
                resp = _ad.IsAuthenticated(srvr, user, pwd);

                if (resp)
                {
                    Session["USERNAME"] = srvr;
                    return Json("Success", JsonRequestBehavior.AllowGet);
                }
            }
            catch(Exception ex)
            {

            }
                return Json("Failure", JsonRequestBehavior.AllowGet);          
        }
        
        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        public ActionResult SignOut()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();

            return RedirectToAction("Login", "Account");

        }
    }
}