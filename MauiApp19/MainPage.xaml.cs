namespace MauiApp19
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAlertClicked(object? sender, EventArgs e)
        {
            if (RodzajLekarza.SelectedItem == null || string.IsNullOrWhiteSpace(RodzajLekarza.SelectedItem.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać rodzaj lekarza.", "OK");
                return;
            }


            if (Data.Date == null || string.IsNullOrWhiteSpace(Data.Date.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać datę wizyty.", "OK");
                return;
            }


            if (Godzina.Time == null || string.IsNullOrWhiteSpace(Godzina.Time.ToString()))
            {
                DisplayAlert("Alert", "Proszę wybrać godzinę wizyty.", "OK");
                return;
            }

            string rodzajlekarza = RodzajLekarza.SelectedItem.ToString();
            string data = Data.Date.ToString();
            string godzina = Godzina.Time.ToString();

            DisplayAlert("Alert", "Wizyta u: " + rodzajlekarza + ", dnia: " + data + ", o godzinie: " + godzina, "OK");
        }
    }
}
