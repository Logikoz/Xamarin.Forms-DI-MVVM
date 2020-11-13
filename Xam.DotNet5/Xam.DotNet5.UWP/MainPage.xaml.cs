namespace Xam.DotNet5.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();

			LoadApplication(new DotNet5.App());
		}
	}
}