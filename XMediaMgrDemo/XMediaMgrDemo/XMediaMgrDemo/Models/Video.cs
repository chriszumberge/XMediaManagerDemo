namespace XMediaMgrDemo.Models
{
    public class Video
    {
        public string Title { get; }
        public string Url { get; }

        public Video(string videoTitle, string videoUrl)
        {
            Title = videoTitle;
            Url = videoUrl;
        }
    }
}
