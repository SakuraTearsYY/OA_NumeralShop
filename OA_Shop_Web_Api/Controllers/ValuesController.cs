using OA_NumeralShop.Bll;
using OA_NumeralShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OA_Shop_Web_Api.Controllers
{
    public class ValuesController : ApiController
    {
        public LstProServices lstProServices 
        { get 
            {
                return new LstProServices();
            } 
        }
        // GET api/values
        [HttpGet]
        public List<LstPro> Ge()
        {
            var data = lstProServices.GetPage(3,1,x=>true,x=>x.ID,true).ToList();
            return data;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
