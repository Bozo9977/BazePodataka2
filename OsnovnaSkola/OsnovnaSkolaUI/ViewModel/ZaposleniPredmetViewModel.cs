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
    public class ZaposleniPredmetViewModel: BindableBase
    {
        public Window Window { get; set; }
        public MyICommand DodajPredmetCommand { get; set; }
        public PredmetIM SelectedPredmet { get; set; }
        public ZaposleniIM SelectedZaposleni { get; set; }

        private List<PredmetIM> predmeti;
        public List<PredmetIM> Predmeti 
        {
            get
            {
                return predmeti;
            }
            set
            {
                predmeti = value;
                OnPropertyChanged("Predmeti");
            }
        }

        public ZaposleniPredmetViewModel(ZaposleniIM zaposleni)
        {
            Predmeti = Channel.Instance.PredmetiProxy.GetPredmeti();
            DodajPredmetCommand = new MyICommand(OnDodajPredmet);
            SelectedZaposleni = zaposleni;
        }

        public void OnDodajPredmet()
        {
            if (SelectedPredmet != null)
            {

                if (Channel.Instance.ZaposleniProxy.ValidatePredmetAdding(SelectedZaposleni.Id_zaposlenog))
                {
                    if(MessageBox.Show("Ovaj nastavnik već ima odabran predmet, da li želite da zamenite taj predmet?","Upozorenje!",MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (Channel.Instance.ZaposleniProxy.AddPredmetToZaposleni(SelectedZaposleni, SelectedPredmet))
                        {
                            MessageBox.Show("Predmet dodat uspešno.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Greška prilikom dodavanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        Window.Close();
                    }
                    else
                    {
                        Window.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Prvo izaberite predmet.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
