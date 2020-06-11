using OsnovnaSkolaPL.Helpers;
using OsnovnaSkolaPL.IntermediaryModels;
using OsnovnaSkolaUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OsnovnaSkolaUI.ViewModel
{
    public class OblastiPredmetaViewModel:BindableBase
    {
        public Window Window { get; set; }
        public MyICommand ChangeOblastCommand { get; set; }
        public MyICommand DeleteOblastCommand { get; set; }
        List<OblastIM> oblasti;
        public List<OblastIM> Oblasti
        {
            get
            {
                return oblasti;
            }
            set
            {
                oblasti = value;
                OnPropertyChanged("Oblasti");
            }
        }
        public OblastIM SelectedOblast { get; set; }
        public PredmetIM SelectedPredmet { get; set; }
        public OblastiPredmetaViewModel(PredmetIM predmet)
        {
            Oblasti = Channel.Instance.PredmetiProxy.GetOblastiForPRedmet(predmet.Id_predmeta);
            ChangeOblastCommand = new MyICommand(OnChangeOblast);
            DeleteOblastCommand = new MyICommand(OnDeleteOblast);
            SelectedPredmet = predmet;
        }

        public void OnChangeOblast()
        {
            new AddOblastWindow(SelectedPredmet, SelectedOblast).ShowDialog();
            Window.Close();
        }

        public void OnDeleteOblast()
        {
            if (SelectedOblast != null)
            {
                if (Channel.Instance.OblastiProxy.DeleteOblast(SelectedOblast))
                {
                    MessageBox.Show("Oblast obrisana", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Greška pri brisanju,", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                Window.Close();
            }
            else
            {
                MessageBox.Show("Prvo izaberite oblast.", "Upozorenje!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
