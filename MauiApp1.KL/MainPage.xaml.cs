

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
            Random r = new Random();
            int diceRoll = r.Next(1, 7);

            if (Dice4RadioButton.IsChecked)
            {
                diceRoll = r.Next(1, 5);
            }
            else if (Dice6RadioButton.IsChecked)
            {
                diceRoll = r.Next(1, 7);
            }
            else if (Dice10RadioButton.IsChecked)
            {
                diceRoll = r.Next(1, 11);
            }
            else if (Dice12RadioButton.IsChecked)
            {
                diceRoll = r.Next(1, 13);
            }

                CounterBtn.Text = "Wylosowany rzut: " + diceRoll.ToString();

            

            

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
