using OA_NumeralShop.Dal;
using OA_NumeralShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Bll
{
    public class LstMenuServices
    {
        readonly LstMenuDal dal = new LstMenuDal();

        public List<LstMenu> Select(Expression<Func<LstMenu, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }
    }
}
