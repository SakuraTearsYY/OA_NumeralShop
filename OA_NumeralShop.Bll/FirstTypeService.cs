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
    public class FirstTypeService
    {
        readonly FirstTypeDal dal = new FirstTypeDal();

        public List<FirstType> Select(Expression<Func<FirstType, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public FirstType Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(FirstType model)
        {
            return dal.Add(model);
        }

        public bool Upd(FirstType model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            FirstType model = new FirstType() { ID = ID };
            return dal.Del(model);
        }
    }
}
