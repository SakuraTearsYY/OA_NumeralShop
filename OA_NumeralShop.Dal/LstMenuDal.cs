using OA_NumeralShop.Model;
using OA_NumeralShop.Model.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Dal
{
    public class LstMenuDal : BaseDal<LstMenu>
    {
        private Core_Entities Db = new Core_Entities();

        public override IQueryable<LstMenu> Select(Expression<Func<LstMenu, bool>> WhereLambda)
        {
            var temp = (from u in Db.FirstType
                        join t in Db.SecondType
                        on u.ID equals t.FirstID
                        into First
                        from fir in First.DefaultIfEmpty()
                        join y in Db.ThirdType
                        on fir.ID equals y.SecondID
                        into Me
                        from Menu in Me.DefaultIfEmpty()
                        select new LstMenu
                        {
                            FirstID = u.ID,
                            FirstName = u.FirstName,
                            SecondID = u.ID,
                            SecondName = fir.SecondName,
                            ThirdID = Menu.SecondID,
                            ThirdName = Menu.ThirdName,

                        }).Where(WhereLambda).AsQueryable();
            return temp;
        }
    }
}
