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
    public partial class ShowAllVideo : System.Web.UI.Page
    {
        private int _page = 1;
        private int _pagesize = 4;
        private int _count = 0;
        private int _total_page = 0;
        public string img_url = string.Empty;
        public string url_status = string.Empty;
        public string live_url = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null) 
            {
                Response.Redirect("Login.aspx");
            }
            int.TryParse(Request.QueryString["p"], out _page);
            _page = _page < 1 ? 1 : _page;
            VideoInfoBLL vib = new VideoInfoBLL();
            video_rpt.DataSource = vib.FindAllVideo(_page, _pagesize, out _count);

            page_str.Text = CreatePageList("videopage", _pagesize, _count, _page, out _total_page);
            page_hide.Text = _page.ToString();

            //初始化查询直播路径
            VideoLiveBLL vlb = new VideoLiveBLL();
            VideoLiveInfo vli = vlb.FindMaxVideo();
            if (string.IsNullOrEmpty(vli.LiveVideoUrl))
            {
                //如果为空就添加操作
                url_status = "insert";
                live_url_hide.Text = "";
            }
            else
            {
                live_url_hide.Text = vli.LiveVideoUrl;
                //否则修改操作
                url_status = "update";
            }


            Page.DataBind();

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

            if (current_page < 5)
            {
                s_page = 1;
                e_page = 10;
            }
            else
            {
                s_page = current_page - 4;
                e_page = current_page + 5;
            }

            if (e_page > total_page) e_page = total_page;

            System.Text.StringBuilder returnStr = new System.Text.StringBuilder();

            string _tr = "<span class=\"mr_10\">共 " + total_row.ToString() + " 条</span>";

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

            if (total_page <= 1) { returnStr = new System.Text.StringBuilder(); }

            return _tr + returnStr.ToString();
        }
    }
}