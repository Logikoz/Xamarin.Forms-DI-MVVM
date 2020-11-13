using System.Threading.Tasks;

using Xam.DotNet5.Services.Interfaces;

using Xamarin.Forms;

namespace Xam.DotNet5.Services
{
	public class HelloService : IHelloService
	{
		public async Task SendHelloAsync(string message)
		{
			await Application.Current.MainPage.DisplayAlert("Hello world", $"{message}", "OK");
		}
	}
}