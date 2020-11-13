using Microsoft.Extensions.DependencyInjection;

using Xam.DI.MVVM.Views;

using Xamarin.Forms;

namespace Xam.DI.MVVM
{
	public partial class App : Application
	{
		public App()
		{
			Startup.Init();

			InitializeComponent();
		}

		protected override void OnStart()
		{
			MainPage = Startup.ServiceProvider.GetService<MainPage>();
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}