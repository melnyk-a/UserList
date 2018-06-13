using UserList.Models.Objects;
using UserList.Models.Repositories;

namespace UserList.Models.Validators
{
    internal class UserExistValidator : IValidator
    {
        private readonly IRepositoryProvider<User> provider;

        public UserExistValidator(IRepositoryProvider<User> provider)
        {
            this.provider = provider;
        }
        public bool IsValid(string value)
        {
            return !provider.Repository.Exists(value);
        }
    }
}