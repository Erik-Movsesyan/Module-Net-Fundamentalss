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
            var isUsernameValid = ValidateUsername(username);

            var greeting = Greeting.GreetUser(username, isUsernameValid);

            MessageBox.Show(greeting);
        }

        static bool ValidateUsername(string username)
        {
            return Regex.IsMatch(username, @"^([a-zA-Z0-9.\-_]){5,20}$");
        }
    }
}