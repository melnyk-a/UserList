using System;

namespace UserList.Views
{
    interface IRegistrationView : IView
    {
        string ConfirmPassword { get; }
        bool ConfirmPasswordApproved { get; set; }
        string Password { get; }
        bool PasswordApproved { get; set; }
        string Username { get; }
        bool UsernameApproved { get; set; }


        event EventHandler PasswordEntered;
        event EventHandler<EventArgs> Register;
        event EventHandler UsernameEntered;
        event EventHandler ConfirmedPasswordEntered;

        void SetErrorForConfirmPassword(string message);
        void SetErrorForPassword(string message);
        void SetErrorForUsername(string message);
        void ShowInformation(string message);
    }
}