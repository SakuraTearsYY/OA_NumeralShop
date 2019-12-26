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
    public class AccountService
    {
        readonly AccountDal dal = new AccountDal();

        public List<Account> Select(Expression<Func<Account,bool>>WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public Account Query(int id) 
        {
            return dal.Query(id);
        }

        public bool Add(Account model) 
        {
            return dal.Add(model);
        }

        public bool Upd(Account model) 
        {
            return dal.Upd(model);
        }

        public bool Del(int ID) 
        {
            Account model = new Account() {ID = ID };
            return dal.Del(model);
        }
    }
}
