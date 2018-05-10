using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XMediaMgrDemo.Models;

namespace XMediaMgrDemo.ViewModels
{
    public class VideoListViewModel : ObservableObject
    {
        public ObservableCollection<Video> Videos { get; set; }

        INavigation _navigation;

        public VideoListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoadData();
        }

        void LoadData()
        {
            Videos = new ObservableCollection<Video>(new List<Video>
            {
                new Video("Composition over Inheritance", "https://www.youtube.com/watch?v=wfMtDGfHWpA"),
                new Video("Closures", "https://www.youtube.com/watch?v=CQqwU2Ixu-U"),
                new Video("Promises in JavaScript", "https://www.youtube.com/watch?v=2d7s3spWAzo"),
                new Video("Streams", "https://www.youtube.com/watch?v=UD2dZw9iHCc")
            });
        }

        ICommand selectProductVideo;
        public ICommand SelectVideoCommand => selectProductVideo ?? (selectProductVideo = new Command<Video>(SelectVideo));

        void SelectVideo(Video video)
        {
            ContinueCommand?.Execute(video);
        }

        ICommand continueCommand;
        public ICommand ContinueCommand => continueCommand ?? (continueCommand = new Command<Video>(Continue));

        void Continue(Video video)
        {
            Device.BeginInvokeOnMainThread(async () => await _navigation.PushAsync(new VideoPlayerPage(video)));
        }
    }
}
