using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA_NumeralShop.Dal
{
    public class BaseDal<T> where T : class, new()
    {
        public DbContext db { get { return GetData.Get(); } }
        public virtual IQueryable<T> Select(Expression<Func<T, bool>> WhereLambda)
        {
            return db.Set<T>().Where(WhereLambda).AsQueryable();
        }

        public virtual T Query(int id)
        {
            return db.Set<T>().Find(id);
        }

        public virtual int Total() 
        {
            return db.Set<T>().Count();
        }

        public virtual IQueryable<T> GetPage<S>(int Size, int PageIndex, Expression<Func<T, bool>> WhereLambda, Expression<Func<T, S>> OrderByLambda, bool IsDesc)
        {
            if (IsDesc)
            {
                var temp = db.Set<T>().Where(WhereLambda)
                    .OrderByDescending(OrderByLambda)
                    .Skip(Size * (PageIndex - 1))
                    .Take(Size)
                    .AsQueryable();
                return temp;
            }
            else
            {
                var temp = db.Set<T>().Where(WhereLambda)
                   .OrderBy(OrderByLambda)
                   .Skip(Size * (PageIndex - 1))
                   .Take(Size)
                   .AsQueryable();
                return temp;
            }
        }

        public virtual bool Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges() > 0;
        }

        public virtual bool Upd(T model)
        {
            db.Entry(model).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Del(T model)
        {
            db.Entry(model).State = EntityState.Deleted;
            return db.SaveChanges() > 0;
        }
    }
}
