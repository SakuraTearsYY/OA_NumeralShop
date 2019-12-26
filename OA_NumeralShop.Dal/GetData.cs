using OA_NumeralShop.Model.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Dal
{
   public class GetData
    {
        public static DbContext Get() 
        {
            return new Core_Entities();
        }
    }
}
