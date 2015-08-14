using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using System.Text;
using BLL;

namespace VideoPlay
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            StringBuilder sb = new StringBuilder();
            context.Response.ContentType = "application/json";
            string id = context.Request.Form["id"];
            //根据id查询单个值
            VideoInfoBLL vib = new VideoInfoBLL();
            VideoInfo vi = vib.FindOneVideo(id);
            if (!string.IsNullOrEmpty(vi.VideoTitle)) 
            {
               
                sb.Append("[");
                sb.Append("{");
                sb.Append("\"title\":\"" +vi.VideoTitle+"\"," );
                sb.Append("\"url\":\"" + vi.VideoUrl + "\",");
                sb.Append("\"meettime\":\"" + vi.VideoTime + "\"");
                //sb.Append("\"id\":\"" + list[i].Bj_Id + "\",");
                sb.Append("}");
                sb.Append("]");
            


            }


            context.Response.ContentEncoding = Encoding.UTF8;

            context.Response.Write(sb);

            context.Response.End();

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}