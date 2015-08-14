using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VideoPlay
{
    public partial class Login : System.Web.UI.Page
    {
        public string p = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
             p = Request.QueryString["p"];
            //if (p == "1")
            //{
            //    Response.Write("<script type=\"text/javascript\">alert(\"用户名或密码错误!\");</script>");
            //  //  Response.Redirect("alert('用户密码错误');");
            //}

        }
    }
}