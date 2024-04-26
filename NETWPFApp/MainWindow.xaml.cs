using GreetingLib;
using System.Text.RegularExpressions;
using System.Windows;

namespace NETWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameInput.Text;
            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(username);
            var isUserNameValid = ValidateUsername(username);

            var greeting = $"{(isNullOrWhiteSpace ? "No username provided!"
                : isUserNameValid
                    ? $"Hello, {username}"
                    : "Invalid Username")}";

            var greetingConcatenated = Greeting.GreetUser(greeting);
            MessageBox.Show(greetingConcatenated);
        }

        static bool ValidateUsername(string username)
        {
            return Regex.IsMatch(username, @"^([a-zA-Z0-9.\-_]){5,20}$");
        }
    }
}