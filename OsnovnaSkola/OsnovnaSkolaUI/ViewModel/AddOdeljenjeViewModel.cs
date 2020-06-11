using OsnovnaSkolaPL.Helpers;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OsnovnaSkolaUI.ViewModel
{
    public class AddOdeljenjeViewModel: BindableBase
    {
        public MyICommand AddOdeljenjeCommand { get; set; }
        public Window Window { get; set; }
        private string content;
        private OdeljenjeIM SelectedOdeljenje = null;
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
        private short razred;
        public short Razred 
        {
            get
            {
                return razred;
            }
            set
            {
                razred = value;
                OnPropertyChanged("Razred");
            }
        }

        public AddOdeljenjeViewModel(OdeljenjeIM odeljenje)
        {
            if(odeljenje == null)
            {
                ButtonContent = "DODAJ";
            }
            else
            {
                ButtonContent = "IZMENI";
                SelectedOdeljenje = odeljenje;
                Razred = SelectedOdeljenje.razred;
            }

            AddOdeljenjeCommand = new MyICommand(OnAddOdeljenje);
        }


        private void OnAddOdeljenje()
        {
            if(SelectedOdeljenje != null)
            {
                if(Razred <=0 || Razred > 8)
                {
                    MessageBox.Show("Razred mora biti u oviru [1-8] intervala.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    SelectedOdeljenje.razred = Razred;
                    if (Channel.Instance.OdeljenjaProxy.ChangeOdeljenje(SelectedOdeljenje))
                    {
                        MessageBox.Show("Odeljenje izmenjeno.", "Operacija uspešna!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška pri izmeni.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                        Window.Close();
                    }
                }
                
            }
            else
            {
                if ( Razred <=0 || Razred>8)
                {
                    MessageBox.Show("Razred mora biti u oviru [1-8] intervala.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    OdeljenjeIM odeljenje = new OdeljenjeIM() { razred = Razred };
                    if (Channel.Instance.OdeljenjaProxy.AddOdeljenje(odeljenje))
                    {
                        MessageBox.Show("Odeljenje dodato.", "Operacija uspešna!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška pri dodavanju.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                        Window.Close();
                    }
                }
                
            }
        }

        

    }
}
