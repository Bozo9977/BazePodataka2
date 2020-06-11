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
    public class AddUcenikViewModel: BindableBase
    {

        public MyICommand AddUcenikCommand { get; set; }
        public Window Window { get; set; }

        public UcenikIM SelectedUcenik { get; set; }

        private string content;
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
        public string Ime { get; set; }
        public string Prezime { get; set; }

        string imeError;
        public string ImeError 
        {
            get
            {
                return imeError;
            }
            set
            {
                imeError = value;
                OnPropertyChanged("ImeError");
            }
        }
        string prezimeError;

        public string PrezimeError 
        {
            get
            {
                return prezimeError;
            }
            set
            {
                prezimeError = value;
                OnPropertyChanged("PrezimeError");
            }
        }

        public AddUcenikViewModel( UcenikIM ucenik)
        {
            AddUcenikCommand = new MyICommand(OnAddUcenik);
            SelectedUcenik = ucenik;
            if (ucenik != null)
            {
                Ime = ucenik.ime;
                Prezime = ucenik.prezime;
                ButtonContent = "IZMENI";
            }
            else
            {
                ButtonContent = "DODAJ";
            }
        }

    


        public void OnAddUcenik()
        {
            if (SelectedUcenik == null)
            {
                ImeError = PrezimeError = "";
                if (String.IsNullOrWhiteSpace(Ime))
                    ImeError = "Morate uneti ime učenika.";
                else if (String.IsNullOrWhiteSpace(Prezime))
                    PrezimeError = "Morate uneti prezime učenika";
                else
                {

                    if (Channel.Instance.UceniciProxy.AddUcenik(new UcenikIM() { ime = Ime, prezime = Prezime }))
                    {

                        MessageBox.Show("Učenik uspešno dodat.", "Operacija uspešna!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                        Window.Close();
                    }
                }

            }
            else
            {
                ImeError = PrezimeError = "";
                if (String.IsNullOrWhiteSpace(Ime))
                    ImeError = "Morate uneti ime učenika.";
                else if (String.IsNullOrWhiteSpace(Prezime))
                    PrezimeError = "Morate uneti prezime učenika";
                else
                {
                    SelectedUcenik.ime = Ime;
                    SelectedUcenik.prezime = Prezime;
                    if (Channel.Instance.UceniciProxy.ChangeUcenik(SelectedUcenik))
                    {
                        MessageBox.Show("Učenik uspešno izmenjen.", "Operacija uspešna.", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom izmene.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                        Window.Close();
                    }
                }
            }
        }

    }
}
