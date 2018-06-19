using System;
using System.Windows.Forms;

namespace UserList.Views
{
    public partial class RegistrationView : Form, IRegistrationView, IView
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        public string ConfirmPassword => confirmPasswordValidator.Input;

        public bool ConfirmPasswordApproved
        {
            get => confirmPasswordValidator.IsValid;
            set
            {
                confirmPasswordValidator.IsValid = value;
                SetRegistrationButton();
            }
        }

        public string Password => passwordValidator.Input;

        public bool PasswordApproved
        {
            get => passwordValidator.IsValid;
            set
            {
                passwordValidator.IsValid = value;
                SetRegistrationButton();
            }
        }

        public string Username => usernameValidator.Input;

        public bool UsernameApproved
        {
            get => usernameValidator.IsValid;
            set
            {
                usernameValidator.IsValid = value;
                SetRegistrationButton();
            }
        }

        public event EventHandler ConfirmedPasswordEntered
        {
            add { confirmPasswordValidator.InputChange += value; }
            remove { confirmPasswordValidator.InputChange -= value; }
        }
        public event EventHandler PasswordEntered
        {
            add { passwordValidator.InputChange += value; }
            remove { passwordValidator.InputChange -= value; }
        }
        public event EventHandler<EventArgs> Register;
        public event EventHandler UsernameEntered
        {
            add { usernameValidator.InputChange += value; }
            remove { usernameValidator.InputChange -= value; }
        }

        private void Clear()
        {
            usernameValidator.Input = null;
            passwordValidator.Input = null;
            confirmPasswordValidator.Input = null;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register.Invoke(sender, e);
        }

        public void SetErrorForConfirmPassword(string message)
        {
            confirmPasswordValidator.SetError(message);
        }

        public void SetErrorForPassword(string message)
        {
            passwordValidator.SetError(message);
        }

        public void SetErrorForUsername(string message)
        {
            usernameValidator.SetError(message);
        }

        private void SetRegistrationButton()
        {
            registerButton.Enabled = UsernameApproved && PasswordApproved && ConfirmPasswordApproved;
        }

        public new void Show()
        {
            Clear();
            ShowDialog();
        }

        public void ShowInformation(string message)
        {
            DialogResult result = MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
