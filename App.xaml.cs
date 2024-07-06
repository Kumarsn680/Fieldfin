namespace Fieldfin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new Fieldfin.View.FieldUser.UserDashboard();
        }
    }
}
