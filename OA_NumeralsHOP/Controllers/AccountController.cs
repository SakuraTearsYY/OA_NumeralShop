using OA_NumeralShop.Bll;
using OA_NumeralShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OA_NumeralsHOP.Controllers
{
    public class AccountController : Controller
    {
        private AccountService accountService { get { return new AccountService(); } }
        private UserInfoService userInfoService { get { return new UserInfoService(); } }
        // GET: Account
        public ActionResult Sigin()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(string Account, string password)
        {
            if (Account != null && password != null)
            {
                var Acc = accountService.Select(x => x.AccNum == Account & x.PassWord == password);
                if (Acc.Count()!=0&& Acc.Count()>0)
                {
                    Session["Info"] = userInfoService.Query(Acc.FirstOrDefault().ID);
                    Session["power"] = Acc.FirstOrDefault().AccrCord;
                    return Json("T");
                }
                else
                {
                    return Json("F");
                }
            }
            else
            {
                return Json("E");
            }
        }
    }
}