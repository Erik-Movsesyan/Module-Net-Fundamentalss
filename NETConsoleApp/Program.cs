using GreetingLib;
using System;
using System.Text.RegularExpressions;

namespace NETConsoleApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Provide your username, please");
        var username = Console.ReadLine();
        var isUserNameNullOrWhiteSpace = string.IsNullOrWhiteSpace(username);
        var isUserNameValid = ValidateUsername(username);

        var greeting = $"{(isUserNameNullOrWhiteSpace ? "No username provided!"
            : isUserNameValid
                ? $"Hello, {username}"
                : "Invalid Username")}";

        var greetingConcatenated = Greeting.GreetUser(greeting);
        Console.WriteLine(greetingConcatenated);
    }

    static bool ValidateUsername(string username)
    {
        return Regex.IsMatch(username, @"^([a-zA-Z0-9.\-_]){5,20}$");
    }
}
