using MAUI.Custom.LoaderEase;

namespace CustomMAUIAnimatedLoadersExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MAUI LOADER INITIAL SETUP
            MAUILoaderRegisterationSetup.ConfigureCustomMAUILoader(mauiWaitLoaderColor: Color.FromArgb("#00FF00"), 
                loaderTextColor: Color.FromArgb("#ffffff"), 
                loaderHeightRequest: 300.0, loaderWidthRequest: 300.0, loaderFontSize: 12.0);
            MainPage = new AppShell();
        }
    }
}


