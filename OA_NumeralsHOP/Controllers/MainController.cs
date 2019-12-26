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
        public SecondTypeService secondTypeService { get { return new SecondTypeService(); } }
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult DeopDowm()
        {
            var data = secondTypeService.Select(x => x.FirstID ==1);
            return Json(data);
        }
    }
}