using System.Threading.Tasks;

namespace Xam.DI.MVVM.Services.Interfaces
{
	public interface IHelloService
	{
		Task SendHelloAsync(string message);
	}
}