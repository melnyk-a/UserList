using System;

namespace UserList.Views
{
    internal interface IUserListView : IView
    {
        string Selected { get; }

        event EventHandler<EventArgs> Delete;
        event EventHandler Load;

        void Add(object item);
        void Clear();
    }
}