using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   

    public class UserDAL
    {
        string contor = ConfigurationManager.ConnectionStrings["sql"].ConnectionString; //

        private UserInfo SetRow(SqlDataReader rd)   //获取一行的数据
        {

            UserInfo row = new UserInfo();
            row.Id = rd["id"].ToString();
            row.PassWord = rd["password"].ToString();
            row.UserName = rd["username"].ToString();
            return row;   
        
        } 
       

        //查询
        public UserInfo FindUser(UserInfo us)
        {
            string sql = "select * from [user] where username=@username and password=@password";
            SqlParameter[] sp = new SqlParameter[]             
            {
                new SqlParameter("@username", SqlDbType.VarChar,50),
                new SqlParameter("@password", SqlDbType.VarChar,50),
            };
            sp[0].Value = us.UserName;
            sp[1].Value = us.PassWord;
            UserInfo row = new UserInfo();
           
             using (SqlDataReader rd = SqlHelper.ExecuteReader(contor, CommandType.Text, sql, sp))
             {
                 if (rd.Read())
                 {
                     row = SetRow(rd);
                 }
                 return row;
             }
        }



    }
}
