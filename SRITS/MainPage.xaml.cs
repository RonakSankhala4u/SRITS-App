namespace SRITS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Load the HTML template
            string filePath = Path.Combine(FileSystem.AppDataDirectory, "Resources", "Raw", "index.html");

            WebView webView = new WebView();

            // Set the WebView source

            webView.Source = new UrlWebViewSource
            {
                Url = filePath
            };

        }

        
    }
      

}
