using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Data
{
    public class LoginState
    {
        public bool IsLoggedIn { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public event Action OnChange;

        public void SetLogin(bool login, string user, string role)
        {
            IsLoggedIn = login;
            username = user;
            this.role = role;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
