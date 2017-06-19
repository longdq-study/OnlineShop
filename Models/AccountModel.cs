using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool login(string username, string password)
        {
            object[] SqlParams = {
                                    new SqlParameter("@username",username),
                                    new SqlParameter ("@password",password),

                              };
            var data = context.Database.SqlQuery<int>("login_admin @username, @password", SqlParams).ToList();

            var res = data.First();

            if (res > 0)
                return true;
            else
                return false;


        }
    }
}
