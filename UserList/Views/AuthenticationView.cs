using System;
using System.Windows.Forms;
using UserList.Properties;

namespace UserList.Views
{
    public partial class AuthenticationView : Form, IAuthenticationView
    {
        private readonly ApplicationContext context;
        public AuthenticationView(ApplicationContext context)
        {
            InitializeComponent();

            this.context = context;
        }

        public string Username => usernameValidator.Input;

        public bool UsernameApproved
        {
            get => usernameValidator.IsValid;
            set
            {
                usernameValidator.IsValid = value;
                SetLoginButton();
            }
        }

        public string Password => passwordValidator.Input;

        public bool PasswordApproved
        {
            get => passwordValidator.IsValid;
            set
            {
                passwordValidator.IsValid = value;
                SetLoginButton();
            }
        }

        public event EventHandler<EventArgs> Login;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login?.Invoke(sender, e);
        }

        private void SetLoginButton()
        {
            loginButton.Enabled = UsernameApproved && PasswordApproved;
        }

        public void SetErrorForPassword(string message)
        {
            passwordValidator.SetError(message);
        }

        public void SetErrorForUsername(string message)
        {
            usernameValidator.SetError(message);
        }

        public new void Show()
        {
            context.MainForm = this;
            System.Windows.Forms.Application.Run(context);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke(sender, e);
        }
    }
}