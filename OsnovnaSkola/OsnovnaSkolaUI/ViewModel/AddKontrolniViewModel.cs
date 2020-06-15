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
    public class AddKontrolniViewModel:BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddKontrolniCommand { get; set; }
        public MyICommand DeleteKontrolniCommand { get; set; }

        public KontrolniIM NoviKontrolni { get; set; }
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
        //string errordp;
        //public string ErrorDatumPredaje
        //{
        //    get
        //    {
        //        return errordp;
        //    }
        //    set
        //    {
        //        errordp = value;
        //        OnPropertyChanged("ErrorDatumPredaje");
        //    }
        //}
        public string DeletionEnabled { get; set; }

        public string ButtonContent { get; set; }


        public OdeljenjeIM SelectedOdeljenje { get; set; }
        public AddKontrolniViewModel(OdeljenjeIM odeljenje, KontrolniIM kontrolni)
        {
            if (kontrolni != null)
            {
                NoviKontrolni = kontrolni;
                changing = true;
                Visible = "Hidden";
                Visible2 = "Visible";
                Naslov = "Promena domaceg";
                ButtonContent = "Izmeni";
                DeletionEnabled = "Visible";
            }
            else
            {
                NoviKontrolni = new KontrolniIM();
                Visible = "Visible";
                Visible2 = "Hidden";
                Naslov = "Novi domaci";
                NoviKontrolni.datum_odrzavanja = DateTime.Today;
                ButtonContent = "Dodaj";
                DeletionEnabled = "Hidden";
            }

            NoviKontrolni.ZaposleniId_zaposlenog = LoggedInZaposleni.Instance.Id_zaposlenog;
            SelectedOdeljenje = odeljenje;
            AddKontrolniCommand = new MyICommand(OnAddKontrolni);
            DeleteKontrolniCommand = new MyICommand(OnDeleteKontrolni);
        }



        public void OnAddKontrolni()
        {
            ErrorZadatak = ErrorDatumZadavanja = "";
            if (String.IsNullOrWhiteSpace(NoviKontrolni.zadatak))
            {
                ErrorZadatak = "Zadatak ne može biti prazan.";
            }
            else if (NoviKontrolni.datum_odrzavanja == null)
            {
                ErrorDatumZadavanja = "Morate izabrati datum zadavanja.";
            }
            else
            {
                if (changing)
                {
                    if (Channel.Instance.KTProxy.ChangeKontrolni(NoviKontrolni))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Greška pri menjanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    if (Channel.Instance.KTProxy.AddKontrolni(NoviKontrolni))
                    {
                        if(Channel.Instance.ZaposleniProxy.DodeliKontrolneTackeUcenicima(LoggedInZaposleni.Instance.Id_zaposlenog, SelectedOdeljenje.Id_odeljenja, 0))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Greška pri dodeljivanju KT ucenicima.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Greška pri dodavanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                Window.Close();
            }

        }

        public void OnDeleteKontrolni()
        {
            if (Channel.Instance.KTProxy.DeleteKontrolni(NoviKontrolni.Id_kontrolne_tacke))
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
