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
    public partial class DeleteVideo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"];
            VideoInfoBLL vib = new VideoInfoBLL();
            if (vib.Delete(id) > 0)
            {
                Response.Redirect("ShowAllVideo.aspx");
            }

        }
    }
}