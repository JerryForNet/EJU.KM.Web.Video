using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{


    public class VideoLiveDAL
    {
        string contor = ConfigurationManager.ConnectionStrings["sql"].ConnectionString; //

        private VideoLiveInfo SetRow(SqlDataReader rd)   //获取一行的数据
        {

            VideoLiveInfo row = new VideoLiveInfo();
            row.Id = rd["id"].ToString();
            row.LiveVideoUrl = rd["live_video_url"].ToString();
           
            return row;   
        
        } 

        //查询id最大的一条数据
        public VideoLiveInfo FindMaxVideo()
        {

            string sql = "select * from dbo.VideoLive where id = (select MAX(id) from VideoLive)";
            VideoLiveInfo vli = new VideoLiveInfo();
            using (SqlDataReader rd = SqlHelper.ExecuteReader(contor, CommandType.Text, sql, null))
            {
                if (rd.Read())
                {
                    vli = SetRow(rd);
                }
                return vli;
            }

        }


        //根据最大的id进行修改修改
        public int UpdateMaxVideo( string url)
        {
            string sql = "update VideoLive set live_video_url= @url where id = (select MAX(id) from VideoLive)";

            SqlParameter[] sp = new SqlParameter[]
            {
              new SqlParameter("@url",SqlDbType.VarChar),
            };
            sp[0].Value = url;

            using (SqlConnection conn = new SqlConnection(contor))
            {
                int val = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);

                return val;
            }

        }


        //添加操作
        public int AddLiveVideoUrl(string url)
        {
            string sql = "insert into VideoLive values(@url)";
            SqlParameter[] sp = new SqlParameter[]
            {
              new SqlParameter("@url",SqlDbType.VarChar),
            };
            sp[0].Value = url;
            using (SqlConnection conn = new SqlConnection(contor))
            {
                int val = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);

                return val;
            }

        }
         
       




    }
}
