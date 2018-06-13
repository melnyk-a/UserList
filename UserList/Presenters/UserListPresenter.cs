using System;
using UserList.Models.Objects;
using UserList.Models.Repositories;
using UserList.Views;

namespace UserList.Presenters
{
    internal sealed class UserListPresenter : IPresenter
    {
        private readonly IUserListView view;
        private readonly IRepositoryProvider<User> provider;

        public UserListPresenter(IUserListView view, IRepositoryProvider<User> provider)
        {
            this.view = view;
            this.provider = provider;

            SubscribeToViewEvents();
        }

        private void Load()
        {
            view.Clear();
            var users = provider.Repository.Items;
            foreach (var user in users)
            {
                view.Add(new UserWrapper(user));
            }
        }

        public void Run()
        {
            view.Show();
        }

        private void SubscribeToViewEvents()
        {
            view.Load += View_Load;
            view.Delete += View_Delete;
        }

        private void View_Delete(object sender, EventArgs e)
        {
            provider.Repository.Delete(view.Selected);
            Load();
        }

        private void View_Load(object sender, EventArgs e)
        {
            Load();
        }
    }
}