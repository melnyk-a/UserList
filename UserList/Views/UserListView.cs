using System;
using System.Windows.Forms;

namespace UserList.Views
{
    public partial class UserListView : Form, IUserListView
    {
        private readonly ApplicationContext context;

        public UserListView(ApplicationContext context)
        {
            InitializeComponent();

            this.context = context;
        }

        public string Selected => userListBox.SelectedItem.ToString();

        public event EventHandler<EventArgs> Delete;
        event EventHandler IUserListView.Load
        {
            add { Load += value; }
            remove { Load -= value; }
        }

        public void Add(object item)
        {
            userListBox.Items.Add(item);
        }

        public void Clear()
        {
            userListBox.Items.Clear();
            SetDeleteButton();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(sender, e);
        }

        private void SetDeleteButton()
        {
            deleteButton.Enabled = userListBox.SelectedIndex != -1;
        }

        public new void Show()
        {
            context.MainForm.Hide();
            context.MainForm = this;
            base.Show();
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeleteButton();
        }
    }
}