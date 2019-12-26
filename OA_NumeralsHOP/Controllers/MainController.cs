using OA_NumeralsHOP.Filter;
using OA_NumeralShop.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OA_NumeralsHOP.Controllers
{
    [MyFilter]
    public class MainController : Controller
    {
        private LstMenuServices userInfoService { get { return new LstMenuServices(); } }
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Menu() 
        {
            if (Session["Info"] != null)
            {
                var data = userInfoService.Select(x => true);
                return Json(data);
            }
            return Json(0);
        }
    }
}