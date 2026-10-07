namespace MauiDemoCrashWebview20261007
{
    public partial class BingWebViewPage : ContentPage
    {
        public string WebViewUrl { get; set; } = "https://www.bing.com";
        public BingWebViewPage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = this;
        }
        private async void OnCloseWebViewClicked(object? sender, EventArgs e)
        {
             await Navigation.PopAsync(true);
        }

    }
}
