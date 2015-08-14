using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDAL ud = new UserDAL();
        public UserInfo FindUser(UserInfo us) 
        {
            return ud.FindUser(us);
        }
    }
}
