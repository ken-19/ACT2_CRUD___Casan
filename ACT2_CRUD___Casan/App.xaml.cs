namespace ACT2_CRUD___Casan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "ACT2_CRUD___Casan" };
        }
    }
}
