namespace MauiDemoCrashWebview20261007
{
    public partial class WebPageLauncherPage : ContentPage
    {
        public WebPageLauncherPage()
        {
            InitializeComponent();
        }

        private async void OnLoadBingClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new BingWebViewPage());
        }
    }
}
