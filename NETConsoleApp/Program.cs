using GreetingLib;
using System;
using System.Text.RegularExpressions;

namespace NETConsoleApp;

public class Program
{

    static void Main(string[] args)
    {
        var userNameProvided = args.Length > 0;
        string username = string.Empty;
        bool isUserNameValid = false;

        if (userNameProvided)
        {
            username = args[0];
            isUserNameValid = ValidateUsername(username);
        }

        var greeting = Greeting.GreetUser(username, isUserNameValid);
        Console.WriteLine(greeting);
    }

    static bool ValidateUsername(string username)
    {
        return Regex.IsMatch(username, @"^([a-zA-Z0-9.\-_]){5,20}$");
    }
}
