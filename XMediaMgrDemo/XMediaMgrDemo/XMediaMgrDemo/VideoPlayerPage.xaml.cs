using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMediaMgrDemo.Models;
using XMediaMgrDemo.ViewModels;

namespace XMediaMgrDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VideoPlayerPage : ContentPage
	{
        VideoPlayerViewModel _viewModel;

		public VideoPlayerPage (Video selectedVideo)
		{
			InitializeComponent ();

            _viewModel = new VideoPlayerViewModel(Navigation, selectedVideo);

            BindingContext = _viewModel;
		}
	}
}