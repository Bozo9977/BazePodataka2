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
    public class UcenikOdeljenjeViewModel: BindableBase
    {
        public Window Window { get; set; }
        private OdeljenjeIM odeljenje;
        public MyICommand DodajOdeljenjeCommand { get; set; }
        List<OdeljenjeIM> odeljenja;
        public List<OdeljenjeIM> Odeljenja 
        {
            get
            {
                return odeljenja;
            }
            set
            {
                odeljenja = value;
                OnPropertyChanged("Odeljenja");
            }
        }
        public OdeljenjeIM SelectedOdeljenje
        {
            get
            {
                return odeljenje;
            }
            set
            {
                odeljenje = value;
                OnPropertyChanged("SelectedOdeljenje");
            }
        }

        public UcenikOdeljenjeViewModel(UcenikIM ucenik)
        {
            Odeljenja = Channel.Instance.OdeljenjaProxy.GetOdeljenja();
            DodajOdeljenjeCommand = new MyICommand(OnDodajOdeljenje);
        }

        public void OnDodajOdeljenje()
        {
            if (SelectedOdeljenje != null)
            {

            }
            else
            {
                MessageBox.Show("Morate prvo izabrati odeljenje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
