using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccessLayer;
using Fieldfin.Service;
using Fieldfin.View.FieldUser;

namespace Fieldfin.MiddleWare
{
    public class LoginLogic
    {
        LoginClass _dbobj = new LoginClass();
        private readonly SessionService _sessionService = new SessionService();
        //private readonly INavigationService _navigation;  // Inject navigation service


        //public LoginLogic(INavigationService navigationService)
        //{
          //  _navigation = navigationService;
        //}

        public void ValidateUserID(string username)
        {
          int retval=  _dbobj.ValidateUserID(username);
          if (retval != 101)
          {
                Application.Current.MainPage.DisplayAlert("Login Error", "Invalid credentials. Please try again.", "OK");
          }
          
        }

        public int ValidatePassword( string usrname, string password) 
        {

            int retval =_dbobj.ValidateLoginDetails(usrname, password);
            return retval;
        }
        //private async Task NavigateToUserPage()
        //{
        //    //await    _navigation.PushAsync(new UserDashboard());
        //    // Alternatively, use _navigation.PushModalAsync(new UserPage()) for modal navigation
        //    await Navigation.PushAsync(new UserDashboard());
        //}
    }
}


//// Example of resetting session timer on user interaction
//private void HandleUserInteraction()
//{
//    _sessionService.ResetSessionTimer();
//}