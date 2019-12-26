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
   public class ProductService
    {
        readonly ProductDal dal = new ProductDal();

        public List<Product> Select(Expression<Func<Product, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public Product Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(Product model)
        {
            return dal.Add(model);
        }

        public bool Upd(Product model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            Product model = new Product() { ID = ID };
            return dal.Del(model);
        }
    }
}
