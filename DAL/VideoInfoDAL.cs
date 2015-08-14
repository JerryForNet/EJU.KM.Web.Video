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


    public class VideoInfoDAL
    {
        string contor = ConfigurationManager.ConnectionStrings["sql"].ConnectionString; //

        private VideoInfo SetRow(SqlDataReader rd)   //获取一行的数据
        {
       
            VideoInfo row = new VideoInfo();
            row.Id = rd["id"].ToString();
            row.VideoTitle = rd["video_title"].ToString();
            row.VideoImg = rd["video_img"].ToString();
            row.VideoTime = rd["video_time"].ToString();
            row.VideoStatus = rd["video_status"].ToString();
            row.VideoMemo = rd["video_memo"].ToString();
            row.VideoTimeLong = rd["video_time_long"].ToString();
            row.VideoUrl = rd["video_url"].ToString();
            return row;   
        
        } 
       

        //分页查询所有
        public List<VideoInfo> FindAllVideo() 
        {
            string sql = "select * from VideoInfo with(nolock) order by id desc";
            List<VideoInfo> list = new List<VideoInfo>();
            using (SqlDataReader rd = SqlHelper.ExecuteReader(contor, CommandType.Text, sql, null))
            {
                while (rd.Read())
                {
                    list.Add(SetRow(rd));
                }

                return list;
            }

        
        }


        //删除操作
        public int Delete(string id) 
        {
            string sql = "delete VideoInfo where id = @id";
            SqlParameter[] sp = new SqlParameter[]
            {
              new SqlParameter("@id", SqlDbType.Int),
            };
            sp[0].Value = id;
            using (SqlConnection conn = new SqlConnection(contor))
            {
                int val = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);
               
                return val;
            }


                
                
                

        }

        //根据id进行查询
        public VideoInfo FindOneVideo(string id)
        {
            string sql = "select * from VideoInfo where id = @id";
            SqlParameter[] sp = new SqlParameter[] {
              new SqlParameter("@id",SqlDbType.Int),
            };
            sp[0].Value = id;
            VideoInfo vi = new VideoInfo();
            using (SqlDataReader rd = SqlHelper.ExecuteReader(contor, CommandType.Text, sql, sp))
            {
                if (rd.Read())
                {
                    vi = SetRow(rd);
                }
                return vi;
            }


        }


        //根据id进行修改
        public int UpdateVideoInfo(VideoInfo vi)
        {           
            string sql = @"update VideoInfo set video_title=@video_title,video_img=@video_img,video_time=@video_time,video_memo=@video_memo,video_time_long=@video_time_long,video_url=@video_url where id=@id";       
            SqlParameter[] sp = new SqlParameter[] {
             new SqlParameter("@video_title",SqlDbType.VarChar),
            new SqlParameter("@video_img",SqlDbType.VarChar),
            new SqlParameter("@video_time",SqlDbType.DateTime),
            new SqlParameter("@video_memo",SqlDbType.VarChar),
            new SqlParameter("@video_time_long",SqlDbType.VarChar),
            new SqlParameter("@video_url",SqlDbType.VarChar),
            new SqlParameter("@id",SqlDbType.Int),
            };
            sp[0].Value = vi.VideoTitle;
            sp[1].Value = vi.VideoImg;
            sp[2].Value = vi.VideoTime;
            sp[3].Value = vi.VideoMemo;
            sp[4].Value = vi.VideoTimeLong;
            sp[5].Value = vi.VideoUrl;
            sp[6].Value = vi.Id;

            using (SqlConnection conn = new SqlConnection(contor))
            {
                int val = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);

                return val;
            }
            

        }

        //添加操作
        public int AddVideoInfo(VideoInfo vi)
        {
            // video_title, video_img, video_time, video_status, video_memo, video_time_long, video_url
            string sql = @"insert into VideoInfo(video_title, video_img, video_time,  video_memo, video_time_long, video_url) 
                                          values(@video_title, @video_img, @video_time,  @video_memo, @video_time_long, @video_url)";
            SqlParameter[] sp = new SqlParameter[] {
             new SqlParameter("@video_title",SqlDbType.VarChar),
            new SqlParameter("@video_img",SqlDbType.VarChar),
            new SqlParameter("@video_time",SqlDbType.DateTime),
            new SqlParameter("@video_memo",SqlDbType.VarChar),
            new SqlParameter("@video_time_long",SqlDbType.VarChar),
            new SqlParameter("@video_url",SqlDbType.VarChar),
            };
            sp[0].Value = vi.VideoTitle;
            sp[1].Value = vi.VideoImg;
            sp[2].Value = vi.VideoTime;
            sp[3].Value = vi.VideoMemo;
            sp[4].Value = vi.VideoTimeLong;
            sp[5].Value = vi.VideoUrl;
          
            using (SqlConnection conn = new SqlConnection(contor))
            {
                int val = SqlHelper.ExecuteNonQuery(conn, CommandType.Text, sql, sp);

                return val;
            }


        }
    
    }
}
