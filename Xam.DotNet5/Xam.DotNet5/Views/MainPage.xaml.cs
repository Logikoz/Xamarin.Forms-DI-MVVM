using Xam.DotNet5.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.DotNet5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage(MainViewModel mainViewModel)
		{
			InitializeComponent();
			BindingContext = mainViewModel;
		}
	}
}