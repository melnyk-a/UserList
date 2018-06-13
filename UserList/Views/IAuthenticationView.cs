using System;

namespace UserList.Views
{
    internal interface IAuthenticationView : IView
    {
        string Username { get; }
        bool UsernameApproved { get; set; }
        string Password { get; }
        bool PasswordApproved { get; set; }

        event EventHandler<EventArgs> Login;
        event EventHandler PasswordEntered;
        event EventHandler<EventArgs> Register;
        event EventHandler UsernameEntered;

        void SetErrorForPassword(string message);
        void SetErrorForUsername(string message);

        void ShowError(string message);
    }
}