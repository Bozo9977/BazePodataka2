using OsnovnaSkola;
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
    public class AddZaposleniViewModel: BindableBase
    {
        #region Fields
        private string naslov { get; set; }
        private string visible { get; set; }
        private string visible2 { get; set; }
        private bool isChange { get; set; }
        //bool admin;
        ZaposleniIM noviZaposleni = new ZaposleniIM();
        #endregion

        public bool UciteljChecked { get; set; }
        public bool RBIsEnabled { get; set; }
        public bool NastavnikChecked { get; set; }
        public string errorIme { get; set; }
        public string ErrorIme
        {
            get { return errorIme; }
            set
            {
                errorIme = value;
                OnPropertyChanged("ErrorIme");
            }
        }

        public string errorPrezime { get; set; }
        public string ErrorPrezime
        {
            get { return errorPrezime; }
            set
            {
                errorPrezime = value;
                OnPropertyChanged("ErrorPrezime");
            }
        }

        public string errorZvanje { get; set; }
        public string ErrorZvanje
        {
            get { return errorZvanje; }
            set
            {
                errorZvanje = value;
                OnPropertyChanged("ErrorZvanje");
            }
        }

        //public string errorPassword { get; set; }
        //public string ErrorPassword
        //{
        //    get { return errorPassword; }
        //    set
        //    {
        //        errorPassword = value;
        //        OnPropertyChanged("ErrorPassword");
        //    }
        //}

        public Window Window { get; set; }
        public bool IsChange
        {
            get { return isChange; }
            set
            {
                isChange = value;
                OnPropertyChanged("IsChange");
            }
        }
        public ZaposleniIM NoviZaposleni
        {
            get { return noviZaposleni; }
            set
            {
                noviZaposleni = value;
                OnPropertyChanged("NoviZaposleni");
            }
        }
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


        //public bool Admin
        //{
        //    get { return admin; }
        //    set
        //    {
        //        admin = value;
        //        OnPropertyChanged("Admin");
        //    }
        //}

        #region Commands
        public MyICommand AddUserCommand { get; set; }
        public MyICommand ChangeInfoCommand { get; set; }
        #endregion

        public AddZaposleniViewModel(bool changing)
        {
            IsChange = changing;
            RBIsEnabled = !changing;
            if (changing)
            {
                //error za change kod korisnika
                NoviZaposleni = LoggedInZaposleni.Instance;
                Naslov = "Promena Informacija";
                Visible = "Hidden";
                Visible2 = "Visible";
                if (NoviZaposleni.Ucitelj)
                {
                    UciteljChecked = true;
                    
                }
                else
                {
                    NastavnikChecked = true;
                }
            }
            else
            {
                Naslov = "Dodaj Zaposlenog";
                Visible = "Visible";
                Visible2 = "Hidden";
            }

            AddUserCommand = new MyICommand(OnAddZaposleni);
            ChangeInfoCommand = new MyICommand(OnChangeInfo);
        }

        public void OnChangeInfo()
        {
            ErrorIme = ErrorPrezime =  "";

            if (String.IsNullOrEmpty(NoviZaposleni.ime))
            {
                ErrorIme = "Ime ne može ostati prazno.";
            }
            else if (String.IsNullOrEmpty(NoviZaposleni.prezime))
            {
                ErrorPrezime = "Prezime ne može ostati prazno.";
            }
            else if (String.IsNullOrEmpty(NoviZaposleni.zvanje))
            {
                ErrorZvanje = "Zvanje ne može ostati prazno.";
            }
            else
            {
                if (Channel.Instance.ZaposleniProxy.ChangeZaposleni(noviZaposleni))
                {
                    LoggedInZaposleni.Instance.ime = noviZaposleni.ime;
                    LoggedInZaposleni.Instance.prezime = noviZaposleni.prezime;
                    LoggedInZaposleni.Instance.zvanje = noviZaposleni.zvanje;

                    Window.Close();
                }
                else
                {
                    ErrorZvanje = "Greška pri izmeni.";
                }
            }

        }

        public void OnAddZaposleni()
        {
            ErrorIme = ErrorPrezime = "";

            if (String.IsNullOrEmpty(NoviZaposleni.ime))
            {
                ErrorIme = "Ime ne može ostati prazno.";
            }
            else if (String.IsNullOrEmpty(NoviZaposleni.prezime))
            {
                ErrorPrezime = "Prezime ne može ostati prazno.";
            }
            else if (String.IsNullOrEmpty(NoviZaposleni.zvanje))
            {
                ErrorZvanje = "Zvanje ne može ostati prazno.";
            }
            else if(!UciteljChecked && !NastavnikChecked)
            {
                ErrorZvanje = "Ucitelj ili nastavnik?";
            }
            else
            {
                ZaposleniIM noviZaposlenik = null;
                if (UciteljChecked)
                    noviZaposlenik = new ZaposleniIM()
                    {
                        ime = NoviZaposleni.ime,
                        prezime = NoviZaposleni.prezime,
                        zvanje = NoviZaposleni.zvanje,
                        Ucitelj = true
                    };
                else
                    noviZaposlenik = new ZaposleniIM()
                    {
                        ime = NoviZaposleni.ime,
                        prezime = NoviZaposleni.prezime,
                        zvanje = NoviZaposleni.zvanje,
                        Ucitelj = false
                    };


                    if (Channel.Instance.ZaposleniProxy.AddZaposleni(noviZaposlenik))
                    {
                        Window.Close();
                    }
                    else
                    {
                        ErrorZvanje = "Greška prilikom dodavanja.";
                    }
            }
        }



    }
}
