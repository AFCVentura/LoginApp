namespace LoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }


        // Code to define the default size of the screen
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = new Window(new AppShell())
            {
                Width = 400,
                Height = 700
            };

            return window;
        }




    }
}