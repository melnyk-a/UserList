namespace UserList.Models.Objects
{
    internal sealed class UserWrapper
    {
        private readonly User user;

        public UserWrapper(User user)
        {
            this.user = user;
        }

        public override string ToString()
        {
            return user.Name.ToString();
        }
    }
}