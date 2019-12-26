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
        public LstProServices lstProServices = new LstProServices();
        
        // GET: Account
        public ActionResult Sigin()
        {
            return View();
        }
    }
}