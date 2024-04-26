namespace GreetingLib
{
    public static class Greeting
    {
        public static string GreetUser(string userName, bool isUserNameValid = true)
        {
            var isNullOrWhiteSpaceWhiteSpace = string.IsNullOrWhiteSpace(userName);

            var greeting = $@"{(isNullOrWhiteSpaceWhiteSpace ? "No username provided!"
                : isUserNameValid
                    ? $"Hello, {userName}"
                    : "Invalid Username")}";

            return greeting;
        }
    }
}
