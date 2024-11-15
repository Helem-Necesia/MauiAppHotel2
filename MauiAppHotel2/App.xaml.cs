namespace MauiAppHotel2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var widow = base.CreateWindow(activationState);
            widow.Width = 400;
            widow.Height = 600;
            
            return widow;
        }

    }
}
