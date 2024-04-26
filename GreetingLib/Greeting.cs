using System;

namespace GreetingLib
{
    public static class Greeting
    {
        public static string GreetUser(string userName)
        {
            return $"[{DateTime.Now}] {userName}";
        }
    }
}
