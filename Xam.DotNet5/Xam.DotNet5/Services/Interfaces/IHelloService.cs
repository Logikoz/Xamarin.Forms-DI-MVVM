using System.Threading.Tasks;

namespace Xam.DotNet5.Services.Interfaces
{
	public interface IHelloService
	{
		Task SendHelloAsync(string message);
	}
}