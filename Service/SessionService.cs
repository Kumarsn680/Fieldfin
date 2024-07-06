using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Fieldfin.Service
{
    public class SessionService
    {
        public bool IsLoggedIn { get; private set; }
        public string UserId { get; private set; }
        private System.Timers.Timer _sessionTimer;

        public SessionService()
        {
            _sessionTimer = new System.Timers.Timer(360000); // 3 minutes in milliseconds
            _sessionTimer.Elapsed += SessionTimeoutElapsed;
            _sessionTimer.AutoReset = false; // Only trigger once
        }

        public void StartSession(string userId)
        {
            UserId = userId;
            IsLoggedIn = true;
            ResetSessionTimer();
        }

        public void EndSession()
        {
            UserId = null;
            IsLoggedIn = false;
            _sessionTimer.Stop();
        }

        private void ResetSessionTimer()
        {
            _sessionTimer.Stop();
            _sessionTimer.Start();
        }

        private void SessionTimeoutElapsed(object sender, ElapsedEventArgs e)
        {
            EndSession();
            // Additional logic to handle session timeout (e.g., show message, navigate to login screen)
        }
    }
}
