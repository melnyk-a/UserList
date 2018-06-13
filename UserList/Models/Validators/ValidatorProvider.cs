using UserList.Models.Objects;
using UserList.Models.Repositories;

namespace UserList.Models.Validators
{
    internal sealed class ValidatorProvider : ILoginValidatorProvider, IRegistrationValidatorProvider
    {
        private IValidator usernameLength = new UsernameLengthValidator();
        private IValidator passwordLength = new PasswordLengthValidator();
        private IValidator userExist;

        public ValidatorProvider(IRepositoryProvider<User> repositoryProvider)
        {
            userExist = new UserExistValidator(repositoryProvider);
        }
        
        public IValidator PasswordLength => passwordLength;

        public IValidator UserExist => userExist;

        public IValidator UsernameLength => usernameLength;
    }
}