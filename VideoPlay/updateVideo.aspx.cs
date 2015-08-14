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
    public partial class updateVideo : System.Web.UI.Page
    {

        public VideoInfo vi = new VideoInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            //接受id
            string id = Request.QueryString["id"];
            VideoInfoBLL vib = new VideoInfoBLL();
            VideoInfo v = vib.FindOneVideo(id);
            vi.VideoTime = FormatDate(v.VideoTime);
            vi.VideoTitle = v.VideoTitle;
            vi.VideoUrl = v.VideoUrl;
            vi.VideoMemo = v.VideoMemo;
            vi.VideoImg = v.VideoImg;
            vi.VideoTimeLong = v.VideoTimeLong;
            vi.Id = v.Id;
            Page.DataBind();

        }
        public string FormatDate(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);

            return dt.ToString("yyyy-MM-dd");
        }
    }
}