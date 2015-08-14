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
    public partial class AddVideo : System.Web.UI.Page
    {
        public string pic = string.Empty;
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
            vi = vib.FindOneVideo(id);
            Page.DataBind();

        }

        //protected void btnSave_Click(object sender, ImageClickEventArgs e)
        //{
        //    VideoInfoBLL vib = new VideoInfoBLL();
        //    string title = Request.Form["meetTitle"];
        //    string meetId = Request.Form["meetId"];
        //    string meetUrl = Request.Form["meetUrl"];
        //    string meetLongTime = Request.Form["meetLongTime"];
        //    string meetTime = Request.Form["meetTime"];
        //    string meet_img = Request.Form["meet_img"];
        //    string meetMemo = Request.Form["meetMemo"];
        //    //  HttpPostedFile hpf = Request.Files["product_img"];
        //    VideoInfo vi = new VideoInfo();

        //    vi.VideoTitle = title;
        //    vi.VideoTime = meetTime;
        //    vi.Id = meetId;
        //    vi.VideoTimeLong = meetLongTime;
        //    vi.VideoMemo = meetMemo;
        //    vi.VideoUrl = meetUrl;
        //    string s2 = this.FileUpload1.PostedFile.FileName;



        //    Random r = new Random();

        //    string ex = System.IO.Path.GetExtension(s2).ToLower();
        //    if (".jpg.gif.png.bmp".Contains(ex))
        //    {
        //        string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(100, 999).ToString() + ex;




        //        vi.VideoImg = newFileName;
        //        Request.Files[0].SaveAs(Server.MapPath("~/image/" + newFileName));
        //        pic = newFileName;
        //    }
        //    if (vib.AddVideoInfo(vi) > 0)
        //    {
        //        Response.Redirect("ShowAllVideo.aspx");

        //    }
        //}

        protected void btnRes_Click(object sender, ImageClickEventArgs e)
        {
        }
    }
}