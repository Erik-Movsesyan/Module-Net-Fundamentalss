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
            var isUsernameValid = ValidateUsername(username);
            var isInputWhiteSpace = string.IsNullOrWhiteSpace(username);

            MessageBox.Show($"{(isInputWhiteSpace ? "No username provided!"
                : isUsernameValid
                    ? $"Hello, {username}"
                    : "Invalid Username")}");
        }

        static bool ValidateUsername(string username)
        {
            return Regex.IsMatch(username, @"^([a-zA-Z0-9.\-_]){5,20}$");
        }
    }
}