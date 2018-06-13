using System.Collections.Generic;

namespace UserList.Models.Repositories
{
    internal interface IRepository<T>
    {
        IEnumerable<T> Items { get; }

        void Add(T item);
        void Delete(string name);
        bool Exists(string name);
        bool Exists(T item);
    }
}