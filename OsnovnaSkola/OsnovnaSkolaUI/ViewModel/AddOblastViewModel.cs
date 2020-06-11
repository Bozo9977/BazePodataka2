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
    public class AddOblastViewModel: BindableBase
    {
        public Window Window { get; set; }
        public MyICommand AddOblastCommand { get; set; }

        private string content;
        private OblastIM SelectedOblast = null;
        private PredmetIM SelectedPredmet = null;
        public string Naslov { get; set; }
        public string ButtonContent
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnPropertyChanged("ButtonContent");
            }
        }
        private string naziv;
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
                OnPropertyChanged("Naziv");
            }
        }
        private string nazivError;
        public string NazivError
        {
            get
            {
                return nazivError;
            }
            set
            {
                nazivError = value;
                OnPropertyChanged("NazivError");
            }
        }

        public AddOblastViewModel(PredmetIM predmet, OblastIM oblast)
        {
            if(oblast == null)
            {
                ButtonContent = "DODAJ";
                Naslov = "Nova oblast";
            }
            else
            {
                ButtonContent = "IZMENI";
                Naslov = $"Izmena oblasti: {oblast.naziv}";
                SelectedOblast = oblast;
                Naziv = SelectedOblast.naziv;
            }
            SelectedPredmet = predmet;
            AddOblastCommand = new MyICommand(OnAddOblast);
        }

        public void OnAddOblast()
        {
            if(SelectedOblast != null)
            {
                if (String.IsNullOrWhiteSpace(Naziv))
                {
                    NazivError = "Naziv oblasti ne može biti prazan.";
                }
                else
                {
                    SelectedOblast.naziv = Naziv;
                    if (Channel.Instance.OblastiProxy.ChangeOblast(SelectedOblast))
                    {
                        MessageBox.Show("Izmena uspešno.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom izmene!", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    Window.Close();
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(Naziv))
                {
                    NazivError = "Naziv oblasti ne može biti prazan.";
                }
                else
                {
                    SelectedOblast = new OblastIM() { naziv = Naziv, PredmetId_predmeta = SelectedPredmet.Id_predmeta };
                    if (Channel.Instance.OblastiProxy.AddOblast(SelectedOblast))
                    {
                        MessageBox.Show("Dodavanje uspešno.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja!", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    Window.Close();
                }
            }
        }
    }
}
