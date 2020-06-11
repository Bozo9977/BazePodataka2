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
    public class AddRazredniViewModel: BindableBase
    {
        bool dodavanjeRazrednog;
        List<ZaposleniIM> zaposleni;
        OdeljenjeIM SelectedOdeljenje;
        public Window Window { get; set; }
        public MyICommand AddRazredniCommand { get; set; }
        public ZaposleniIM SelectedZaposleni { get; set; }
        public List<ZaposleniIM> Zaposleni 
        {
            get
            {
                return zaposleni;
            }
            set
            {
                zaposleni = value;
                OnPropertyChanged("Zaposleni");
            }
        }

        public AddRazredniViewModel(OdeljenjeIM odeljenje, bool dodavanjeRazrednog)
        {
            if (dodavanjeRazrednog)
                Zaposleni = Channel.Instance.ZaposleniProxy.GetZaposleni().Where(x => x.Ucitelj == false).ToList();
            else
                Zaposleni = Channel.Instance.ZaposleniProxy.GetZaposleni();
            this.dodavanjeRazrednog = dodavanjeRazrednog;
            SelectedOdeljenje = odeljenje;

            AddRazredniCommand = new MyICommand(OnAddRazredni);
        }

        public void OnAddRazredni()
        {
            if (SelectedZaposleni != null)
            {
                if (dodavanjeRazrednog)
                {
                    if (Channel.Instance.OdeljenjaProxy.AddRazredni(SelectedOdeljenje, SelectedZaposleni))
                    {
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Razredni već postoji.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        Window.Close();
                    }
                }
                else
                {
                    if (Channel.Instance.OdeljenjaProxy.ValidateUciteljExistance(SelectedOdeljenje.Id_odeljenja))
                    {
                        if(MessageBox.Show("Učitelj već postoji, da li želite da ga zamenite?","Pažnja!",MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            if (Channel.Instance.OdeljenjaProxy.AddNastavnik(SelectedOdeljenje, SelectedZaposleni))
                            {
                                Window.Close();
                            }
                            else
                            {
                                MessageBox.Show("Greška prilikom dodavanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
                                Window.Close();
                            }
                        }
                        else
                        {
                            Window.Close();
                        }
                    }
                    else
                    {
                        if (Channel.Instance.OdeljenjaProxy.AddNastavnik(SelectedOdeljenje, SelectedZaposleni))
                        {
                            Window.Close();
                        }
                        else
                        {
                            MessageBox.Show("Greška prilikom dodavanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
                            Window.Close();
                        }
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Selektujte zaposlenog prvo.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

    }
}
