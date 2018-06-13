using System;
using UserList.Models.Messages;
using UserList.Models.Objects;
using UserList.Models.Repositories;
using UserList.Models.Validators;
using UserList.Views;

namespace UserList.Presenters
{
    internal sealed class AuthenticationPresenter : IPresenter
    {
        private readonly ILoginValidatorProvider provider;
        private readonly IPresenter registrationPresenter;
        private readonly IRepositoryProvider<User> repositoryProvider;
        private readonly IPresenter userListPresenter;
        private readonly IAuthenticationView view;

        public AuthenticationPresenter(
            IAuthenticationView view,
            ILoginValidatorProvider provider,
            IRepositoryProvider<User> repositoryProvider,
            UserListPresenter userListPresenter,
            RegistrationPresenter registrationPresenter
            )
        {
            this.provider = provider;
            this.view = view;
            this.repositoryProvider = repositoryProvider;
            this.registrationPresenter = registrationPresenter;
            this.userListPresenter = userListPresenter;

            SubscribeToViewEvents();
            SetUpView();
        }

        public void Run()
        {
            view.Show();
        }

        private void SetUpView()
        {
            view.SetErrorForPassword(ValidationMessages.EmptyPassword);
            view.SetErrorForUsername(ValidationMessages.UsernameLength);
        }

        private void ShowUserList()
        {
            userListPresenter.Run();
        }

        private void SubscribeToViewEvents()
        {
            view.Login += View_Login;
            view.PasswordEntered += View_PasswordEntered;
            view.Register += View_Register;
            view.UsernameEntered += View_UsernameEntered;
        }

        private void View_Login(object sender, EventArgs e)
        {
            bool isExist = repositoryProvider.Repository.Exists(new User(view.Username, view.Password));
            if (isExist)
            {
                ShowUserList();
            }
            else
            {
                view.ShowError(ValidationMessages.IncorrectInput);
            }
        }

        private void View_PasswordEntered(object sender, EventArgs e)
        {
            bool isValid = provider.PasswordLength.IsValid(view.Password);
            view.PasswordApproved = isValid;
            string message = !isValid ? ValidationMessages.EmptyPassword : null;
            view.SetErrorForPassword(message);
        }

        private void View_Register(object sender, EventArgs e)
        {
            registrationPresenter.Run();
        }

        private void View_UsernameEntered(object sender, EventArgs e)
        {
            bool isValid = provider.UsernameLength.IsValid(view.Username);
            view.UsernameApproved = isValid;
            string message = !isValid ? ValidationMessages.UsernameLength : null;
            view.SetErrorForUsername(message);
        }
    }
}