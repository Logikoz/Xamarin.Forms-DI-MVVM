using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Reflection;

using Xam.DotNet5.Services;
using Xam.DotNet5.Services.Interfaces;
using Xam.DotNet5.ViewModels;
using Xam.DotNet5.Views;

using Xamarin.Essentials;

namespace Xam.DotNet5
{
	public static class Startup
	{
		public static IServiceProvider ServiceProvider { get; set; }

		public static void Init()
		{
			var a = Assembly.GetExecutingAssembly();
			using (var stream = a.GetManifestResourceStream("Xam.DotNet5.appsettings.json"))
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