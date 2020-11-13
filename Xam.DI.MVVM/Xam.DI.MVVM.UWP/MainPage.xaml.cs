namespace Xam.DI.MVVM.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();

			LoadApplication(new MVVM.App());
		}
	}
}