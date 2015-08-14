using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Collections;







namespace BLL
{
    public class VideoInfoBLL
    {
        VideoInfoDAL vi = new VideoInfoDAL();
        private List<VideoInfo> GetOnePageData(int p, int r, List<VideoInfo> data)
        {
            List<VideoInfo> list = new List<VideoInfo>();

            int rowCount = data.Count;

            p = p < 1 ? 1 : p;
            r = r < 1 ? 20 : r;

            int p_start = 0;
            int p_end = 0;
            p_start = (p - 1) * r;
            p_end = p * r;
            if (p_end > rowCount) p_end = rowCount;

            for (int i = p_start; i < p_end; i++)
            {
                list.Add(data[i]);
            }

            return list;
        }

        public List<VideoInfo> FindAllVideo(int p, int r, out int rowCount)
        {
            List<VideoInfo> data = new List<VideoInfo>();
            rowCount = 0;
            data = vi.FindAllVideo();
            rowCount = (data != null) ? data.Count : 0;
            data = GetOnePageData(p, r, data);
            return data;
        }

        public int Delete(string id) 
        {
            return vi.Delete(id);
        }

                //根据id进行查询
        public VideoInfo FindOneVideo(string id)
        {
            return vi.FindOneVideo(id);
        }

                //根据id进行修改
        public int UpdateVideoInfo(VideoInfo vif)
        {
            return vi.UpdateVideoInfo(vif);
        }

        //添加操作
        public int AddVideoInfo(VideoInfo vif)
        {
            return vi.AddVideoInfo(vif);
        }
    }
}
