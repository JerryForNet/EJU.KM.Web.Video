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
    public partial class ReturnBack : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {

            VideoLiveBLL vlb = new VideoLiveBLL();
            VideoLiveInfo vli = vlb.FindMaxVideo();
            Response.Write(vli.LiveVideoUrl);


        }
    }
}