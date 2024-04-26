namespace MAUIApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else if(count > 2)
                CounterBtn.Text = $"Clicked {count} times (this button doesn't really do anything)";
            else if (count > 4)
                CounterBtn.Text = $"Clicked {count} times (seriously, it doesn't!)";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
