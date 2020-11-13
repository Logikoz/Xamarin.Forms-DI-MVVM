using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Reflection;

using Xam.DI.MVVM.Services;
using Xam.DI.MVVM.Services.Interfaces;
using Xam.DI.MVVM.ViewModels;
using Xam.DI.MVVM.Views;

using Xamarin.Essentials;

namespace Xam.DI.MVVM
{
	public static class Startup
	{
		public static IServiceProvider ServiceProvider { get; set; }

		public static void Init()
		{
			var a = Assembly.GetExecutingAssembly();
			using (var stream = a.GetManifestResourceStream("Xam.DI.MVVM.appsettings.json"))
			{
				var host = new HostBuilder()
				   .UseContentRoot(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
				   .ConfigureHostConfiguration(c =>
				   {
					   c.AddCommandLine(new string[] { $"ContentRoot={FileSystem.AppDataDirectory}" });
					   c.AddJsonStream(stream);
				   })
				   .ConfigureServices(ConfigureServices)
				   .Build();

				ServiceProvider = host.Services;
			}
		}

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IHelloService, HelloService>();
			services.AddSingleton<MainViewModel>();
			services.AddSingleton<MainPage>();
		}
	}
}