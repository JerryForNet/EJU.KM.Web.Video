using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class VideoLiveBLL
    {


        VideoLiveDAL vi = new VideoLiveDAL();

        public int AddLiveVideoUrl(string url)
        {
            return vi.AddLiveVideoUrl(url);
        }

        public int UpdateMaxVideo(string url)
        {
            return vi.UpdateMaxVideo(url);
        }

        public VideoLiveInfo FindMaxVideo() 
        {
            return vi.FindMaxVideo();
        }

    }
}
