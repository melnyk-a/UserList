namespace UserList.Models.Validators
{
    internal interface ILoginValidatorProvider
    {
        IValidator PasswordLength { get; }
        IValidator UsernameLength { get; }
    }
}