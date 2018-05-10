using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XMediaMgrDemo.ViewModels;

namespace XMediaMgrDemo
{
	public partial class MainPage : ContentPage
	{
		VideoListViewModel _viewModel;

		public MainPage()
		{
			InitializeComponent();

			_viewModel = new VideoListViewModel(Navigation);

			BindingContext = _viewModel;
		}
	}
}
