namespace MauiApp19;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	void ObliczCene_Clicked(object sender, EventArgs e)
	{
		var imie= Imie.Text;
		var nazwisko = Nazwisko.Text;
		var email = Email.Text;
        var data = Data.Date.ToString();
        var towarzysze = DodatkoweOsobyStepper.Value.ToString();
        if (Firma.SelectedItem==null || RadioButtonGroup.GetSelectedValue(PakietGroup)==null)
		{
            DisplayAlert("B³¹d", "Proszê wype³niæ wymagane pola", "OK");
            return;
        }
		else 
		{
			var firma = Firma.SelectedItem.ToString();
            var pakiet = RadioButtonGroup.GetSelectedValue(PakietGroup).ToString();
            if (string.IsNullOrWhiteSpace(imie) ||  string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firma))
            {
                DisplayAlert("B³¹d", "Proszê wype³niæ wymagane pola", "OK");
            }
            else
            {
                var cena = double.Parse(pakiet) + (int.Parse(towarzysze)*100);

                DisplayAlert("Sukces", $"Dane zosta³y wprowadzone poprawnie:\nImiê: {imie}\nNazwisko: {nazwisko}\nEmail: {email}\nFirma: {firma}\nData: {data}\nPakiet: {pakiet}z³\nLiczba osób towarzysz¹cych: {towarzysze}\nCena ca³kowita: {cena}z³", "OK");
            }
        }
    }
}