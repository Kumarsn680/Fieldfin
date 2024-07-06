using Fieldfin.MiddleWare;

namespace Fieldfin.View.Login;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

	private async void LoginCheck(object sender, EventArgs e)
	{
        LoginLogic obj = new LoginLogic();
        obj.ValidateUserID(usrName.Text);
        int value = obj.ValidatePassword(usrName.Text, pswd.Text);
        if (value == 101)
        {
           
            App.Current.MainPage = new Fieldfin.View.FieldUser.UserDashboard();
            await Navigation.PushAsync(new FieldUser.UserDashboard());
        }
    }
}