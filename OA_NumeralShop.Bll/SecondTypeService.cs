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
   public class SecondTypeService
    {
        readonly SecondTypeDal dal = new SecondTypeDal();

        public List<SecondType> Select(Expression<Func<SecondType, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public SecondType Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(SecondType model)
        {
            return dal.Add(model);
        }

        public bool Upd(SecondType model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            SecondType model = new SecondType() { ID = ID };
            return dal.Del(model);
        }
    }
}
