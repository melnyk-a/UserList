namespace UserList.Models.Validators
{
    internal interface IRegistrationValidatorProvider : ILoginValidatorProvider
    {
        IValidator UserExist { get; }
    }
}