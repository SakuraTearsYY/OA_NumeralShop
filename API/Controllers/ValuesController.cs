using OA_NumeralShop.Bll;
using OA_NumeralShop.Model;
using OA_NumeralShop.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        public LstProServices lstProServices
        {
            get
            {
                return new LstProServices();
            }
        }
        // GET api/values
        public List<LstPro> Get() 
        {
            var data = lstProServices.GetPage(3, 1, x => true, x => x.ID, true).ToList();
            return data;
        }
    }
}
