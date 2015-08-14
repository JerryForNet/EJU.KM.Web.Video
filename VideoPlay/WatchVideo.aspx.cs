using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Text;

namespace VideoPlay
{
    public partial class WatchVideo : System.Web.UI.Page
    {
        private int _page = 1;
        private int _pagesize = 6;
        private int _count = 0;
        private int _total_page = 0;
        public string usercode = "";
        public StringBuilder sb = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)  //usercode
        {
            usercode = Request.QueryString["usercode"];
            if (!IsPostBack)
            {
                EJUWebService.UCWebService ejuws = new EJUWebService.UCWebService();

                returnbk.Visible = false;
                //if (!(ejuws.CheckLogin(usercode)))
                //{
                //    Response.Redirect("http://in.eju.com");
                //}
                //else
                //{

                #region
                    this.litreturnzhibo.Text = "<a href=\"WatchVideo.aspx?usercode=" + usercode + "\">回到直播</a>";

                    int.TryParse(Request.QueryString["p"], out _page);
                    _page = _page < 1 ? 1 : _page;
                    VideoInfoBLL vib = new VideoInfoBLL();
                    List<VideoInfo> list = null;
                    list = vib.FindAllVideo(_page, _pagesize, out _count);
                    if (list != null && list.Count > 0)
                    {
                        video_rpt.DataSource = list;
                        page_str.Text = CreatePageList("videopage", _pagesize, _count, _page, out _total_page);
                        page_hide.Text = _page.ToString();
                    }
                    else
                    {
                        this.litMsg.Text = "暂无视频";
                    }
                    //查询初始路径

                    VideoLiveBLL vlb = new VideoLiveBLL();
                    VideoLiveInfo vli = vlb.FindMaxVideo();
                    //Response.Write(vli.LiveVideoUrl);
                    string id = Request.QueryString["id"];

                    #region 拼接js

                    //第一次登陆
                    if (string.IsNullOrEmpty(id))
                    {
                        sb.Append("jwplayer('mediaspace').setup({");
                        sb.Append(" 'screencolor':'FFFFFF',");
                        sb.Append(" 'flashplayer': 'player.swf',");
                        sb.Append(" 'file': 'livestream1',");
                        sb.Append(" 'image': 'image/eju.png',");
                        sb.Append("'streamer': '" + vli.LiveVideoUrl + "',");
                        sb.Append("'controlbar': 'bottom',");
                        sb.Append("'width': '556',");
                        sb.Append(" 'height': '384',");
                        sb.Append(" 'stretching':'fill' ");
                        sb.Append("});");

                    }
                    else
                    {
                        returnbk.Visible = true;
                        //根据id查询           
                        VideoInfo vi = vib.FindOneVideo(id);
                        meet_time.Text = FormatDate(vi.VideoTime);
                        meet_top.Text = vi.VideoTitle;
                        string filename = vi.VideoUrl.Substring(vi.VideoUrl.LastIndexOf("/") + 1);
                        sb.Append("jwplayer('mediaspace').setup({");
                        sb.Append(" 'screencolor':'FFFFFF',");
                        sb.Append(" 'flashplayer': 'player.swf',");
                        sb.Append(" 'file': '" + filename + "',");
                        sb.Append(" 'image': 'image/eju.png',");
                        int fileindex = vi.VideoUrl.LastIndexOf("/");
                        sb.Append("'streamer': '" + vi.VideoUrl.Substring(0, fileindex) + "',");
                        sb.Append("'controlbar': 'bottom',");
                        sb.Append("'width': '556',");
                        sb.Append(" 'height': '384',");
                        sb.Append("'stretching':'fill'");
                        sb.Append("});");

                    }
                    #endregion
                    Page.DataBind();
#endregion
                //}
            }
        }
        protected void Video_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
        public string FormatDate(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);

            return dt.ToString("yyyy-MM-dd");
        }

        public string CreatePageList(string js_fn, int page_size, int total_row, int current_page, out int total_page)
        {
            int s_page;
            int e_page;

            total_page = Convert.ToInt32(total_row / page_size);
            total_page = (total_row % page_size > 0) ? total_page + 1 : total_page;

            if (current_page < 1 || current_page > total_page) current_page = 1;

            if (current_page < 3)
            {
                s_page = 1;
                e_page = 4;
            }
            else
            {
                s_page = current_page - 1;
                e_page = current_page + 2;
            }

            if (e_page > total_page) e_page = total_page;

            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();

            //  string _tr = "<span class=\"mr_10\">共 " + total_row.ToString() + " 条</span>";

            for (int i = s_page; i <= e_page; i++)
            {
                if (i == current_page)
                {
                    returnStr.Append("<a class=\"focus\">" + i + "</a>");
                }
                else
                {
                    returnStr.Append(@"<a href=""javascript:" + js_fn + "('" + i + @"')"">" + i + "</a>");
                }
            }

            if (current_page != 1)
                returnStr.Insert(0, @"<a href=""javascript:" + js_fn + "('" + (current_page - 1) + @"')"" class=""previous"" >上一页</a>");
            //else
            //    returnStr.Insert(0, @"<a class=""btn-none"">上一页</a>");

            if (current_page < total_page)
                returnStr.Append(@"<a href=""javascript:" + js_fn + "('" + (current_page + 1) + @"')"" class=""next"">下一页</a>");
            //else
            //    returnStr.Append(@"<a class=""btn-none"">下一页</a>");

            if (total_page <= 1) { returnStr = new StringBuilder(); }

            return returnStr.ToString();
        }

    }
}