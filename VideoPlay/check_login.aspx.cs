using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace VideoPlay
{
    public partial class check_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            string username = Request.Form["username"];
            string pwd = Request.Form["pwd"];
            UserInfo us = new UserInfo();
            us.PassWord = pwd;
            us.UserName = username;
            UserBLL ub = new UserBLL();
            UserInfo row = ub.FindUser(us);
            if (string.IsNullOrEmpty(row.PassWord))
            {
                Response.Redirect("Login.aspx?p=1");

                ////说明没有用户
                //Response.Write("<script type=\"text/javascript\">alert(\"用户名或密码错误!\");</script>");

            }
            else
            {
                //登陆成功 将用户存入session
                Session["username"] = row.UserName;
                Response.Redirect("ShowAllVideo.aspx");
                

            }



        }
    }
}