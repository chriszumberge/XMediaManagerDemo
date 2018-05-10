using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XMediaMgrDemo.Models;

namespace XMediaMgrDemo.ViewModels
{
    public class VideoPlayerViewModel : ObservableObject
    {
        Video _video;
        public Video Video
        {
            get
            {
                return _video;
            }
            set
            {
                SetProperty(ref _video, value);
            }
        }

        INavigation _navigation;

        public VideoPlayerViewModel(INavigation navigation, Video selectedVideo)
        {
            Video = selectedVideo;
            _navigation = navigation;
        }
    }
}
