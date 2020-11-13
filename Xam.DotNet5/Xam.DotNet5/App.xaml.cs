using Microsoft.Extensions.DependencyInjection;

using Xam.DotNet5.Views;

using Xamarin.Forms;

namespace Xam.DotNet5
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