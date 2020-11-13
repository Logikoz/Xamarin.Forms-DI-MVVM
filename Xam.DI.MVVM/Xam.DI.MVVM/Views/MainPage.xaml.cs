using Xam.DI.MVVM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam.DI.MVVM.Views
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