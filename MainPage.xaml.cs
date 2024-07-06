using System;

namespace Fieldfin
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //MainPage = new Fieldfin.View.FieldUser.UserDashboard();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Login.Login());
        }
    }

}
