using System;

namespace UserList.Models.Objects
{
    internal sealed class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public String Name { get; }

        public String Password { get; }
    }
}