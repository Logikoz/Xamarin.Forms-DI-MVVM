using System.Threading.Tasks;

using Xam.DI.MVVM.Services.Interfaces;

using Xamarin.Forms;

namespace Xam.DI.MVVM.Services
{
	public class HelloService : IHelloService
	{
		public async Task SendHelloAsync(string message)
		{
			await Application.Current.MainPage.DisplayAlert("Hello world", $"{message}", "OK");
		}
	}
}