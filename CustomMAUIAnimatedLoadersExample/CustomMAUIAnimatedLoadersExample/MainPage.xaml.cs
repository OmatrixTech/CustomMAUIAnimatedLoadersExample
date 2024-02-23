using MAUI.Custom.LoaderEase.AppPresentations.CommonSource;

namespace CustomMAUIAnimatedLoadersExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = MauiServiceHandler.Current.GetServices<MainPageViewModel>().FirstOrDefault();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
