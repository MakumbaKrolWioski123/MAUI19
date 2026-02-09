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
            string rodzajlekarza = RodzajLekarza.SelectedItem.ToString();
            string data = Data.Date.ToString();
            string godzina = Godzina.Time.ToString();
            if (RodzajLekarza.SelectedItem == null)
            {
                DisplayAlert("Alert", "Proszę wybrać rodzaj lekarza.", "OK");
                return;
            }
            else if
            (Data.Date == null)
            {
                DisplayAlert("Alert", "Proszę wybrać datę wizyty.", "OK");
                return;
            }
            else if (Godzina.Time == null)
            {
                DisplayAlert("Alert", "Proszę wybrać godzinę wizyty.", "OK");
                return;
            }
            else
            {
                DisplayAlert("Alert", "Wizyta u: " + rodzajlekarza + ", dnia: " + data + ", o godzinie: " + godzina, "OK");
                return;
            }
        }
    }
}
