using System;
using System.Threading.Tasks;

namespace BlazorReactiveSample
{
    public enum LoginStatus { LogOut, LoggedIn }

    public class AuthState
    {
        public LoginStatus Status { get; private set; }

        public event Action OnChange;

        void NotifyAuthChanged() => OnChange?.Invoke();

        public async Task Login(/* UserData userData */)
        {
            await Task.Delay(100); // dummy
            Status = LoginStatus.LoggedIn;
            NotifyAuthChanged();
        }

        public async Task Logout()
        {
            await Task.Delay(100); // dummy
            Status = LoginStatus.LogOut;
            NotifyAuthChanged();
        }
    }
}
