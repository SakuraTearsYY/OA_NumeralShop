using OA_NumeralShop.Dal;
using OA_NumeralShop.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Bll
{
   public class ThirdTypeService
    {
        readonly ThirdTypeDal dal = new ThirdTypeDal();

        public List<ThirdType> Select(Expression<Func<ThirdType, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public ThirdType Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(ThirdType model)
        {
            return dal.Add(model);
        }

        public bool Upd(ThirdType model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            ThirdType model = new ThirdType() { ID = ID };
            return dal.Del(model);
        }
    }
}
