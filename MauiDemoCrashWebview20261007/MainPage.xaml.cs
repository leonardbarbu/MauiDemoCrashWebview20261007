namespace MauiDemoCrashWebview20261007
{
    public partial class MainPage : FlyoutPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        private async void OnOpenWebPageClicked(object? sender, EventArgs e)
        {
            await Detail.Navigation.PushAsync(new WebPageLauncherPage());
        }
    }
}
