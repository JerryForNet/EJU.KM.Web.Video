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
    public partial class AddLiveVideo : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            string url = Request.QueryString["url"];
            VideoLiveBLL vib = new VideoLiveBLL();
            if (vib.AddLiveVideoUrl(url) > 0)
            {
                Response.Redirect("ShowAllVideo.aspx");
            }
            else
            {

            }
        }
    }
}