namespace UserList.Models.Validators
{
    internal sealed class PasswordLengthValidator : IValidator
    {
        public bool IsValid(string value)
        {
            return value.Length != 0;
        }
    }
}