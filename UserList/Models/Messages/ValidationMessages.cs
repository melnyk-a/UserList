namespace UserList.Models.Messages
{
    internal static class ValidationMessages
    {
        public static string UsernameLength => "Username cannot be less 5 characters.";

        public static string UsernameExist => "Username already exist.";

        public static string EmptyPassword => "Password cannot be empty.";

        public static string ConfirmationEmptyPassword => "Confirmation password cannot be empty.";

        public static string PasswordMismatch => "Password do not match.";

        public static string IncorrectInput => "Incorrect username or password";
    }
}