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
    public class LstProServices
    {
        readonly LstProDal dal = new LstProDal();

        public List<LstPro> Select(Expression<Func<LstPro, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public LstPro Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(LstPro model)
        {
            return dal.Add(model);
        }

        public bool Upd(LstPro model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            LstPro model = new LstPro() { ID = ID };
            return dal.Del(model);
        }

        public IQueryable<LstPro> GetPage<S>(int Size, int PageIndex, Expression<Func<LstPro, bool>> WhereLambda, Expression<Func<LstPro, S>> OrderByLambda, bool IsDesc)
        {
            return dal.GetPage(Size,PageIndex,WhereLambda,OrderByLambda,IsDesc);
        }
    }
}
