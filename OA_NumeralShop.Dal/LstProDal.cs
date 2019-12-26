using OA_NumeralShop.Model;
using OA_NumeralShop.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Dal
{
    public class LstProDal : BaseDal<LstPro>
    {
        private Core_Entities Db = new Core_Entities();
        public override IQueryable<LstPro> GetPage<S>(int Size, int PageIndex, Expression<Func<LstPro, bool>> WhereLambda, Expression<Func<LstPro, S>> OrderByLambda, bool IsDesc)
        {
            if (IsDesc)
            {
                var temp = (from u in Db.Product
                            join t in Db.ThirdType
                            on u.ThirdID equals t.ID
                            select new LstPro
                            {
                                ID = u.ID,
                                ProName = u.ProName,
                                ProPrices = u.ProPrices,
                                ThirdID = u.ThirdID,
                                Details = u.Details,
                                Amount = u.Amount,
                                Picture = u.Picture,
                                ThirdName = t.ThirdName,
                                SecondID = t.SecondID
                            })
                            .Where(WhereLambda)
                            .OrderByDescending(OrderByLambda)
                            .Skip(Size * (PageIndex - 1))
                            .Take(Size)
                            .AsQueryable();
                return temp;
            }
            else
            {
                var temp = (from u in Db.Product
                            join t in Db.ThirdType
                            on u.ThirdID equals t.ID
                            select new LstPro
                            {
                                ID = u.ID,
                                ProName = u.ProName,
                                ProPrices = u.ProPrices,
                                ThirdID = u.ThirdID,
                                Details = u.Details,
                                Amount = u.Amount,
                                Picture = u.Picture,
                                ThirdName = t.ThirdName,
                                SecondID = t.SecondID
                            })
                            .Where(WhereLambda)
                            .OrderBy(OrderByLambda)
                            .Skip(Size * (PageIndex - 1))
                            .Take(Size)
                            .AsQueryable();
                return temp;
            }
        }
    }
}
