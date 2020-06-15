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
    public class OceniRadoveViewModel:BindableBase
    {
        public Window Window { get; set; }

        public MyICommand OceniCommand { get; set; }
        List<RadiIM> radovi;
        public List<RadiIM> Radovi 
        {
            get
            {
                return radovi;
            }
            set
            {
                radovi = value;
                OnPropertyChanged("Radovi");
            }
        }


        public OceniRadoveViewModel(int idKT)
        {
            Radovi = Channel.Instance.RadoviProxy.GetRadoviForKontrolnaTacka(LoggedInZaposleni.Instance.Id_zaposlenog, idKT);
            OceniCommand = new MyICommand(OnOceni);
        }

        public void OnOceni()
        {
            if(Radovi.Any(r=>r.ocena<1) || Radovi.Any(r => r.ocena > 5))
            {
                MessageBox.Show("Sve ocene moraju biti u opsegu [1-5].", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (var item in Radovi)
                {
                    if (Channel.Instance.RadoviProxy.ChangeRad(item))
                        continue;
                    else
                    {
                        MessageBox.Show("Greška pri izmeni rada.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                }

                Window.Close();
            }

            
        }
    }
}
