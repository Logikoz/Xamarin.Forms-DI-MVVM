using Microsoft.Extensions.Configuration;

using System.Threading.Tasks;
using System.Windows.Input;

using Xam.DotNet5.Services.Interfaces;

using Xamarin.Forms;

namespace Xam.DotNet5.ViewModels
{
	public class MainViewModel
	{
		private readonly IHelloService _hello;
		private readonly IConfiguration _configuration;

		public ICommand SendCommand { get; set; }

		public MainViewModel(IHelloService hello, IConfiguration configuration)
		{
			_hello = hello;
			_configuration = configuration;

			SendCommand = new Command(async () => await SendHelloAsync());
		}

		private async Task SendHelloAsync()
		{
			await _hello.SendHelloAsync(_configuration["Text"]);
		}
	}
}