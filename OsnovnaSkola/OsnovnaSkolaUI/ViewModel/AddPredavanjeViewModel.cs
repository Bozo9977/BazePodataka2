using OsnovnaSkolaPL.Helpers;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OsnovnaSkolaUI.ViewModel
{
    public class AddPredavanjeViewModel: BindableBase
    {
        private string opis;
        private string date;
        private string opisError;
        private string dateError;
        private DateTime datum;
        public DateTime SelectedDatum 
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
                OnPropertyChanged("SelectedDatum");
            }
        }



        public Window Window { get; set; }
        public Grid LoginGrid { get; set; }
        public MyICommand AddPredavanjeCommand { get; set; }
        public string Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
                OnPropertyChanged("Opis");
            }
        }
        public string OpisError
        {
            get
            {
                return opisError;
            }
            set
            {
                opisError = value;
                OnPropertyChanged("OpisError");
            }
        }
        public string DateError
        {
            get
            {
                return dateError;
            }
            set
            {
                dateError = value;
                OnPropertyChanged("DateError");
            }
        }

        public OblastIM Oblast { get; set; }
        private PredavanjeIM SelectedPredavanje = null;
        public AddPredavanjeViewModel(OblastIM oblast, PredavanjeIM predavanje)
        {
            if (predavanje!=null)
            {
                Opis = predavanje.opis;
                SelectedDatum = predavanje.datum_odrzavanja;
                SelectedPredavanje = predavanje;
            }
            else
            {
                SelectedDatum = DateTime.Today;
                Oblast = oblast;
            }
            
            
            AddPredavanjeCommand = new MyICommand(OnAddPredavanje);
        }



        public void OnAddPredavanje()
        {
            if (String.IsNullOrWhiteSpace(Opis))
            {
                OpisError = "Opis ne može biti prazan.";
            }
            else if(SelectedDatum == null)
            {
                DateError = "Izaberite datum.";
            }
            else
            {
                if(SelectedPredavanje == null)
                {
                    PredavanjeIM p = new PredavanjeIM()
                    {
                        OblastId_oblasti = Oblast.Id_oblasti,
                        ZaposleniId_zaposlenog = LoggedInZaposleni.Instance.Id_zaposlenog,
                        datum_odrzavanja = SelectedDatum,
                        opis = Opis
                    };
                    if (Channel.Instance.PredavanjaProxy.AddPredavanjeForZaposleni(p))
                    {
                        MessageBox.Show("Predavanje dodato.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Greška pri dodavanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    SelectedPredavanje.opis = Opis;
                    SelectedPredavanje.datum_odrzavanja = SelectedDatum;
                    if (Channel.Instance.PredavanjaProxy.ChangePredavanje(SelectedPredavanje))
                    {
                        MessageBox.Show("Predavanje izmenjeno.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Greška pri izmeni.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                
                Window.Close();
            }
            

        }

    }
}
