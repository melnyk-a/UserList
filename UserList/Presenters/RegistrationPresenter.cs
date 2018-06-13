using System;
using UserList.Models.Messages;
using UserList.Models.Objects;
using UserList.Models.Repositories;
using UserList.Models.Validators;
using UserList.Views;

namespace UserList.Presenters
{
    internal sealed class RegistrationPresenter : IPresenter
    {
        private readonly IRegistrationView view;
        private readonly IRegistrationValidatorProvider provider;
        private readonly IRepositoryProvider<User> repositoryProvider;

        public RegistrationPresenter(IRegistrationView view, IRegistrationValidatorProvider provider, IRepositoryProvider<User> repositoryProvider)
        {
            this.provider = provider;
            this.view = view;
            this.repositoryProvider = repositoryProvider;

            SubscribeToViewEvents();
            SetUpView();
        }

        private void CheckConfirmPassword()
        {
            bool isValid = provider.PasswordLength.IsValid(view.ConfirmPassword);
            if (!isValid)
            {
                view.ConfirmPasswordApproved = isValid;
                string message = !isValid ? ValidationMessages.EmptyPassword : null;
                view.SetErrorForConfirmPassword(message);
            }
            else
            {
                isValid = view.Password == view.ConfirmPassword;
                view.ConfirmPasswordApproved = isValid;
                string message = !isValid ? ValidationMessages.PasswordMismatch : null;
                view.SetErrorForConfirmPassword(message);
            }
        }

        private void CheckPassword()
        {
            bool isValid = provider.PasswordLength.IsValid(view.Password);
            view.PasswordApproved = isValid;
            string message = !isValid ? ValidationMessages.EmptyPassword : null;
            view.SetErrorForPassword(message);
        }

        public void Run()
        {
            view.Show();
        }

        private void SetUpView()
        {
            view.SetErrorForPassword(ValidationMessages.EmptyPassword);
            view.SetErrorForUsername(ValidationMessages.UsernameLength);
            view.SetErrorForConfirmPassword(ValidationMessages.ConfirmationEmptyPassword);
        }

        private void SubscribeToViewEvents()
        {
            view.PasswordEntered += View_PasswordEntered;
            view.Register += View_Register;
            view.UsernameEntered += View_UsernameEntered;
            view.ConfirmedPasswordEntered += View_ConfirmedPasswordEntered;
        }

        private void View_ConfirmedPasswordEntered(object sender, EventArgs e)
        {
            CheckPassword();
            CheckConfirmPassword();
        }


        private void View_PasswordEntered(object sender, EventArgs e)
        {
            CheckPassword();
            CheckConfirmPassword();
        }

        private void View_Register(object sender, EventArgs e)
        {
            repositoryProvider.Repository.Add(new User(view.Username, view.Password));
            view.ShowInformation(InformationMessages.UserCreated(view.Username));
        }

        private void View_UsernameEntered(object sender, EventArgs e)
        {
            bool isValid = provider.UsernameLength.IsValid(view.Username);
            if (!isValid)
            {
                view.UsernameApproved = isValid;
                string message = !isValid ? ValidationMessages.UsernameLength : null;
                view.SetErrorForUsername(message);
            }
            else
            {
                isValid = provider.UserExist.IsValid(view.Username);
                view.UsernameApproved = isValid;
                string message = !isValid ? ValidationMessages.UsernameExist : null;
                view.SetErrorForUsername(message);
            }
        }
    }
}