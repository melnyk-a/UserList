namespace UserList.Models.Validators
{
    internal interface IValidator
    {
        bool IsValid(string value);
    }
}