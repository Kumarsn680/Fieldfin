namespace Fieldfin.View.FieldUser;

public partial class UserDashboard : ContentPage
{
	public UserDashboard()
	{

        InitializeComponent();
	}
    private void NavigateHome_Clicked(object sender, EventArgs e)
    {
        //Detail = new NavigationPage(new HomePage());
        //IsPresented = false; // Close the flyout
    }

    private void NavigateProfile_Clicked(object sender, EventArgs e)
    {
       // Detail = new NavigationPage(new ProfilePage());
        //IsPresented = false; // Close the flyout
    }

    private void NavigateSettings_Clicked(object sender, EventArgs e)
    {
        //Detail = new NavigationPage(new SettingsPage());
        //IsPresented = false; // Close the flyout
    }



}