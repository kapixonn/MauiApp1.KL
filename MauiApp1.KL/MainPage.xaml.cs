namespace MauiApp1.KL
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
            Random r = new Ramdom();
            int diceRoll = r.Next(1, 7);

            CounterBtn.Text = "Wylosowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
