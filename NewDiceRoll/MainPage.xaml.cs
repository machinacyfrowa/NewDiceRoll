namespace NewDiceRoll
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // stwórz obiekt klasy Random - grenerator liczb losowych
            Random r = new Random();
            //domyślnie losuj K6
            int diceRoll = 6;
            // sprawdź, który guzik jest zaznaczony
            if(K4.IsChecked)
            {
                diceRoll = r.Next(1, 5);
            }
            if (K6.IsChecked)
            {
                diceRoll = r.Next(1, 7);
            }
            if (K10.IsChecked)
            {
                diceRoll = r.Next(1, 11);
            }
            if (K12.IsChecked)
            {
                diceRoll = r.Next(1, 13);
            }
            // wyświetl wynik w guziku
            RollLabel.Text = "Wynik rzutu: " + diceRoll.ToString();
        }
    }

}
