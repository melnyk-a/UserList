using System;
using System.Windows.Forms;
using UserList.Properties;

namespace UserList.Views
{
    public partial class InputValidator : UserControl
    {
        private bool isValid;

        public InputValidator()
        {
            InitializeComponent();
        }

        public string Input
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public bool IsValid
        {
            get => isValid;
            set
            {
                isValid = value;
                UpdatePictureBox();
            }
        }

        public string Title
        {
            get => label.Text;
            set => label.Text = value;
        }

        public event EventHandler InputChange
        {
            add => textBox.TextChanged += value;
            remove => textBox.TextChanged -= value;
        }

        public void SetError(string message)
        {
            validationToolTip.SetToolTip(pictureBox, message);
        }

        private void UpdatePictureBox()
        {
            pictureBox.Image = isValid ? Resources.Correct : Resources.Incorrect;
        }
    }
}