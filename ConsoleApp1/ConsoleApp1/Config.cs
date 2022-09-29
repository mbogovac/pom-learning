
namespace ConsoleApp1
{
    public static class Config
    {
        public static string BaseUrl = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfG";
                }

                public static class Password
                {
                    public static string NoSpecialCharacters = "a1234";
                }

                public static class Email
                {
                    public static string InvalidFormat = "example.com";
                }

            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
            public static string UsernameLenghtOutOfRange = "User Id should not be empty / length be between 5 to 12";
        }

    }
}