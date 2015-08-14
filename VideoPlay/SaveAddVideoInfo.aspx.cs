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
    public partial class SaveAddVideoInfo : System.Web.UI.Page
    {

        public string pic = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            VideoInfoBLL vib = new VideoInfoBLL();
            string title = Request.Form["meetTitle"];
            string meetId = Request.Form["meetId"];
            string meetUrl = Request.Form["meetUrl"];
            string meetLongTime = Request.Form["meetLongTime"];
            string meetTime = Request.Form["meetTime"];
            string meet_img = Request.Form["meet_img"];
            string meetMemo = Request.Form["meetMemo"];
            //  HttpPostedFile hpf = Request.Files["product_img"];
            VideoInfo vi = new VideoInfo();

            vi.VideoTitle = title;
            vi.VideoTime = meetTime;
            vi.Id = meetId;
            vi.VideoTimeLong = meetLongTime;
            vi.VideoMemo = meetMemo;
            vi.VideoUrl = meetUrl;



            if (Request.Files[0].FileName != "")
            {
                Random r = new Random();
                string ex = System.IO.Path.GetExtension(Request.Files[0].FileName).ToLower();
                if (".jpg.gif.png.bmp".Contains(ex))
                {
                    string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(100, 999).ToString() + ex;




                    vi.VideoImg = newFileName;
                    Request.Files[0].SaveAs(Server.MapPath("~/image/" + newFileName));
                    pic = newFileName;
                }
            }
            else
            {
                vi.VideoImg = "默认.jpg";
            }
            if (vib.AddVideoInfo(vi) > 0)
            {
                Response.Redirect("ShowAllVideo.aspx");

            }



        }
    }
}