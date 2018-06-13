namespace UserList.Models.Validators
{
    internal sealed class UsernameLengthValidator : IValidator
    {
        private const int maxLength = 5;

        public bool IsValid(string value)
        {
            return value.Length >= maxLength;
        }
    }
}