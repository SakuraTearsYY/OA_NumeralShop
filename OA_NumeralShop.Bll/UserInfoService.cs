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
   public class UserInfoService
    {
        readonly UserInfoDal dal = new UserInfoDal();

        public List<UserInfo> Select(Expression<Func<UserInfo, bool>> WhereLambda)
        {
            return dal.Select(WhereLambda).ToList();
        }

        public UserInfo Query(int id)
        {
            return dal.Query(id);
        }

        public bool Add(UserInfo model)
        {
            return dal.Add(model);
        }

        public bool Upd(UserInfo model)
        {
            return dal.Upd(model);
        }

        public bool Del(int ID)
        {
            UserInfo model = new UserInfo() { ID = ID };
            return dal.Del(model);
        }
    }
}
