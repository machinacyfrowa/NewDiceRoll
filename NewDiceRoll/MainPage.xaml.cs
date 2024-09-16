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
            // wylosuj liczbę z zakresu od 1 do 6
            int diceRoll = r.Next(1, 7);
            // wyświetl wynik w guziku
            CounterBtn.Text = "Wynik rzutu: " + diceRoll.ToString();
        }
    }

}
