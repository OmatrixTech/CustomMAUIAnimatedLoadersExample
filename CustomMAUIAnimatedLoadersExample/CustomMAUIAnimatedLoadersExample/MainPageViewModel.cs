using MAUI.Custom.LoaderEase.Interfaces;

namespace CustomMAUIAnimatedLoadersExample
{
    public class MainPageViewModel
    {
        ICustomLoaderHandlerService loaderHandlerService = null;

        [Obsolete]
        public MainPageViewModel(ICustomLoaderHandlerService loaderHandlerService)
        {
            this.loaderHandlerService = loaderHandlerService;
            ShowWaitWindow();
            CloseLoader();
        }
        private void ShowWaitWindow()
        {
            //To display the loader using the Dependency Injection service.
            if (loaderHandlerService != null)
                loaderHandlerService.ShowCustomLoader(message: "Processing");

            //To display the loader without generating an instance.
            //LoaderHandler.ShowCustomLoader(message: "Searching", loaderType: LoaderType.QuantumQuikLoader);
        }
        [Obsolete]
        private void CloseLoader()
        {
            Device.StartTimer(TimeSpan.FromSeconds(20), () =>
            {
                //To hide the loader using the Dependency Injection service.
                loaderHandlerService.HideCustomLoader();

                //To hide the loader without generating an instance.
                //LoaderHandler.HideCustomLoader();
                return false;
            });
        }
    }
}
