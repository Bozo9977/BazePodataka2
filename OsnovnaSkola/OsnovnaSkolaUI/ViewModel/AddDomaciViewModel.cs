using OsnovnaSkolaPL.Helpers;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OsnovnaSkolaUI.ViewModel
{
    public class AddDomaciViewModel : BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddDomaciCommand { get; set; }
        public MyICommand DeleteDomaciCommand { get; set; }

        public DomaciIM NoviDomaci { get; set; }
        bool changing = false;

        private string naslov { get; set; }
        private string visible { get; set; }
        private string visible2 { get; set; }
        public string Naslov
        {
            get { return naslov; }
            set
            {
                naslov = value;
                OnPropertyChanged("Naslov");
            }
        }
        public string Visible
        {
            get { return visible; }
            set
            {
                visible = value;
                OnPropertyChanged("Visible");
            }
        }

        public string Visible2
        {
            get { return visible2; }
            set
            {
                visible2 = value;
                OnPropertyChanged("Visible2");
            }
        }


        string errorZadatak;
        public string ErrorZadatak 
        {
            get
            {
                return errorZadatak;
            }
            set
            {
                errorZadatak = value;
                OnPropertyChanged("ErrorZadatak");
            }
        }

        string errordz;
        public string ErrorDatumZadavanja 
        {
            get
            {
                return errordz;
            }
            set
            {
                errordz = value;
                OnPropertyChanged("ErrorDatumZadavanja");
            }
        }
        string errordp;
        public string ErrorDatumPredaje 
        {
            get
            {
                return errordp;
            }
            set
            {
                errordp = value;
                OnPropertyChanged("ErrorDatumPredaje");
            }
        }
        public string DeletionEnabled { get; set; }

        public string ButtonContent { get; set; }
        public OdeljenjeIM SelectedOdeljenje { get; set; }
        public AddDomaciViewModel(OdeljenjeIM odeljenje, DomaciIM domaci)
        {
            if (domaci != null)
            {
                NoviDomaci = domaci;
                changing = true;
                Visible = "Hidden";
                Visible2 = "Visible";
                Naslov = "Promena domaceg";
                ButtonContent = "Izmeni";
                DeletionEnabled = "Visible";
            }
            else
            {
                NoviDomaci = new DomaciIM();
                Visible = "Visible";
                Visible2 = "Hidden";
                Naslov = "Novi domaci";
                NoviDomaci.dan_predaje = DateTime.Today;
                NoviDomaci.dan_zadavanja = DateTime.Today;
                ButtonContent = "Dodaj";
                DeletionEnabled = "Hidden";
            }

            NoviDomaci.ZaposleniId_zaposlenog = LoggedInZaposleni.Instance.Id_zaposlenog;
            SelectedOdeljenje = odeljenje;
            AddDomaciCommand = new MyICommand(OnAddDomaci);
            DeleteDomaciCommand = new MyICommand(OnDeleteDomaci);
        }

        public void OnAddDomaci()
        {
            ErrorZadatak = ErrorDatumZadavanja = ErrorDatumPredaje = "";
            if (String.IsNullOrWhiteSpace(NoviDomaci.zadatak))
            {
                ErrorZadatak = "Zadatak ne može biti prazan.";
            }
            else if(NoviDomaci.dan_predaje == null)
            {
                ErrorDatumPredaje = "Morate izabrati datum predaje.";
            }
            else if(NoviDomaci.dan_zadavanja == null)
            {
                ErrorDatumZadavanja = "Morate izabrati datum zadavanja.";
            }
            else
            {
                if (changing)
                {
                    if (Channel.Instance.KTProxy.ChangeDomaci(NoviDomaci))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Greška pri menjanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {

                    if (Channel.Instance.KTProxy.AddDomaci(NoviDomaci))
                    {
                        Channel.Instance.ZaposleniProxy.DodeliKontrolneTackeUcenicima(LoggedInZaposleni.Instance.Id_zaposlenog, SelectedOdeljenje.Id_odeljenja, 0);
                    }
                    else
                    {
                        MessageBox.Show("Greška pri dodavanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                Window.Close();
            }

            
        }


        public void OnDeleteDomaci()
        {
            if (Channel.Instance.KTProxy.DeleteDomaci(NoviDomaci.Id_kontrolne_tacke))
            {

            }
            else
            {
                MessageBox.Show("Greška pri brisanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Window.Close();
        }
    }
}
