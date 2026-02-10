using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp19;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new RozmiaryViewModel();
    }

	public class RozmiaryViewModel : INotifyPropertyChanged
	{
        public RozmiaryViewModel()
        {
            WybranaIlosc = 1; 
        }

        private int _wybranyRozmiar;
		private int _wybraneCiasto;
		private int _wybranaIlosc;
        private int _cena;

        public int WybranyRozmiar
		{
			get => _wybranyRozmiar;
			set
			{
				if (_wybranyRozmiar != value)
				{
					_wybranyRozmiar = value;
					OnPropertyChanged(nameof(WybranyRozmiar));
					OnPropertyChanged(nameof(Cena));
                }
			}
		}

		public int WybraneCiasto
		{
			get => _wybraneCiasto;
			set
			{
				if (_wybraneCiasto != value)
				{
					_wybraneCiasto = value;
					OnPropertyChanged(nameof(WybraneCiasto));
                    OnPropertyChanged(nameof(Cena));
                }
			}
        }

		public int WybranaIlosc
        {
			get => _wybranaIlosc;
            set
            {
				if (_wybranaIlosc != value)
				{
					_wybranaIlosc = value;
					OnPropertyChanged(nameof(WybranaIlosc));
                    OnPropertyChanged(nameof(Cena));
                }
            }
        }

		public int Cena
		{
			get
			{
				if (_wybranyRozmiar <= 0) return 0;
				var ciasto = 0;
				if (_wybraneCiasto == 1|| _wybraneCiasto == 2)
				{
					ciasto = 0;
                }
				
				if (_wybraneCiasto == 5)
                {	
					ciasto = 5;
                }

                return (WybranyRozmiar + ciasto) * WybranaIlosc;

            }
		}
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
