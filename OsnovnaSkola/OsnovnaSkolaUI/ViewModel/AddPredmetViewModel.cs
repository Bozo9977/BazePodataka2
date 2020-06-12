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
    class AddPredmetViewModel: BindableBase
    {
        public MyICommand AddPredmetCommand { get; set; }
        public MyICommand ChangePredmetCommand { get; set; }
        public Window Window { get; set; }

        private string visible { get; set; }
        private string visible2 { get; set; }
        private bool isChange { get; set; }
        private string naslov;
        private PredmetIM noviPredmet;
        public PredmetIM NoviPredmet 
        {
            get
            {
                return noviPredmet;
            }
            set
            {
                noviPredmet = value;
                OnPropertyChanged("NoviPredmet");
            }
        }
        public string Naslov 
        {
            get
            {
                return naslov;
            }
            set
            {
                naslov = value;
                OnPropertyChanged("Naslov");
            }
        }
        
        public bool IsChange
        {
            get { return isChange; }
            set
            {
                isChange = value;
                OnPropertyChanged("IsChange");
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

        public string errorNaziv { get; set; }
        public string ErrorNaziv
        {
            get { return errorNaziv; }
            set
            {
                errorNaziv = value;
                OnPropertyChanged("ErrorNaziv");
            }
        }

        public string errorRazred { get; set; }
        public string ErrorRazred
        {
            get { return errorRazred; }
            set
            {
                errorRazred = value;
                OnPropertyChanged("ErrorRazred");
            }
        }

        public string errorBrO { get; set; }
        public string ErrorBrojOblasti
        {
            get { return errorBrO; }
            set
            {
                errorBrO = value;
                OnPropertyChanged("ErrorBrojOblasti");
            }
        }


        public AddPredmetViewModel(PredmetIM predmet)
        {
            if(predmet == null)
            {
                NoviPredmet = new PredmetIM();
                Naslov = "Novi predmet";
                Visible = "Visible";
                Visible2 = "Hidden";
            }
            else
            {
                NoviPredmet = predmet;
                Naslov = "Izmeni predmet";
                Visible = "Hidden";
                Visible2 = "Visible";
            }

            AddPredmetCommand = new MyICommand(OnAddPredmet);
            ChangePredmetCommand = new MyICommand(OnChangePredmet);
        }


        public void OnAddPredmet()
        {
            ErrorNaziv = ErrorRazred = ErrorBrojOblasti = "";

            if (String.IsNullOrEmpty(NoviPredmet.naziv))
            {
                ErrorNaziv = "Naziv ne može ostati prazan.";
            }
            else if (NoviPredmet.razred<=0 ||NoviPredmet.razred >8)
            {
                ErrorRazred = "Razred mora biti u opsegu [1-8].";
            }
            else if (NoviPredmet.broj_oblasti<0)
            {
                ErrorBrojOblasti = "Broj oblasti mora biti pozitivan broj.";
            }
            else
            {
                if (Channel.Instance.PredmetiProxy.AddPredmet(NoviPredmet))
                {
                    Window.Close();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void OnChangePredmet()
        {
            ErrorNaziv = ErrorRazred = ErrorBrojOblasti = "";

            if (String.IsNullOrEmpty(NoviPredmet.naziv))
            {
                ErrorNaziv = "Naziv ne može ostati prazan.";
            }
            else if (NoviPredmet.razred <= 0 || NoviPredmet.razred > 8)
            {
                ErrorRazred = "Razred mora biti u opsegu [1-8].";
            }
            else if (NoviPredmet.broj_oblasti < 0)
            {
                ErrorBrojOblasti = "Broj oblasti mora biti pozitivan broj.";
            }
            else
            {
                //NoviPredmet.razred
                if (Channel.Instance.PredmetiProxy.ChangePredmet(NoviPredmet))
                {
                    Window.Close();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}
