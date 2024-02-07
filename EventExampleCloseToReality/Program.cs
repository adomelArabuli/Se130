namespace EventExampleCloseToReality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YoutubeChannel channel = new YoutubeChannel();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(channel);
            channel.UploadVideo("Test video","https://Yotube.com/channel/TestVideo");
            subscriber.UnSubscribe(channel);
            channel.UploadVideo("Test video2","https://Yotube.com/channel/TestVideo2");
        }
    }

    public class YoutubeChannel
    {
        public event Action<string, string> VideoUploadEvent;

        protected virtual void OnVideoUpload(string videoTitle, string path)
        {
            VideoUploadEvent?.Invoke(videoTitle, path);
        } 

        public void UploadVideo(string videoTitle, string path)
        {
            OnVideoUpload(videoTitle, path);
        }
    }

    public class Subscriber
    {
        public void VideoUploadHandler1(string videoTiTle, string path)
        {
            Console.WriteLine($"Viewer: Video alert! title: {videoTiTle} check out link here {path}");
        }

        public void VideoUploadHandler2(string videoTiTle, string path)
        {
            string filePath = "C:\\Users\\a.arabuli\\Desktop\\txt.txt";

            using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"I want to log the url of the new video {path}");
                }
            }
        }

        public void VideoUploadHandler3(string videoTiTle, string path)
        {
            string filePath = "C:\\Users\\a.arabuli\\Desktop\\txt.txt";
            string content = string.Empty;

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }

        public void Subscribe(YoutubeChannel channel)
        {
            channel.VideoUploadEvent += VideoUploadHandler1;
            channel.VideoUploadEvent += VideoUploadHandler2;
            channel.VideoUploadEvent += VideoUploadHandler3;
        }

        public void UnSubscribe(YoutubeChannel channel)
        {
            channel.VideoUploadEvent -= VideoUploadHandler1;
            channel.VideoUploadEvent -= VideoUploadHandler2;
            channel.VideoUploadEvent -= VideoUploadHandler2;
        }
    }
}