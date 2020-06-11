using OsnovnaSkola;
using OsnovnaSkolaPL.Helpers;
using OsnovnaSkolaPL.IntermediaryModels;
using OsnovnaSkolaUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OsnovnaSkolaUI.ViewModel
{
    public class MainViewModel: BindableBase
    {

        #region Commands
        public MyICommand AddZaposleniCommand { get; set; }
        public MyICommand ChangeInfoCommand { get; set; }
        public MyICommand DeleteZaposleniCommand { get; set; }
        public MyICommand AddUcenikCommand { get; set; }
        public MyICommand ChangeUcenikCommand { get; set; }
        public MyICommand DeleteUcenikCommand { get; set; }
        public MyICommand AddOdeljenjeCommand { get; set; }
        public MyICommand ChangeOdeljenjeCommand { get; set; }
        public MyICommand AddRazrednogCommand { get; set; }
        public MyICommand AddNastavnikCommand { get; set; }
        public MyICommand DeleteOdeljenjeCommand { get; set; }
        public MyICommand AddPredmetCommand { get; set; }
        public MyICommand AddOblastCommand { get; set; }
        public MyICommand ChangeOblastCommand { get; set; }

        #endregion


        public Window Window { get; set; }
        public string IsAdmin { get; set; }
        public string  AuthorizeAdmin { get; set; }
        public ZaposleniIM SelectedZaposleni { get; set; }

        List<ZaposleniIM> zaposleni { get; set; }
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

        public PredmetIM SelectedPredmet { get; set; }
        List<PredmetIM> predmeti { get; set; }
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

        List<OdeljenjeIM> odeljenja { get; set; }
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
        List<UcenikIM> ucenici { get; set; }
        public List<UcenikIM> Ucenici 
        {
            get
            {
                return ucenici;
            }
            set
            {
                ucenici = value;
                OnPropertyChanged("Ucenici");
            }
        }

        public UcenikIM SelectedUcenik { get; set; }
        public OdeljenjeIM SelectedOdeljenje { get; set; }
        public ZaposleniIM loggedIn { get; set; }
        public ZaposleniIM LoggedIn
        {
            get
            {
                return loggedIn;
            }
            set
            {
                loggedIn = value;
                OnPropertyChanged("LoggedIn");
            }
        }



        public MainViewModel()
        {
            LoggedIn = LoggedInZaposleni.Instance;
            if(LoggedInZaposleni.Instance.ime != "admin")
            {
                IsAdmin = "Visible";
                AuthorizeAdmin = "Hidden";
            }
            else
            {
                IsAdmin = "Hidden";
                AuthorizeAdmin = "Visible";
            }

            try
            {
                OnChange();
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: \n"+e.Message + "Trace: \n"+e.StackTrace);
            }

            


            AddZaposleniCommand = new MyICommand(OnAddZaposleni);
            ChangeInfoCommand = new MyICommand(OnChangeZaposleni);
            DeleteZaposleniCommand = new MyICommand(OnDeleteZaposleni);

            AddUcenikCommand = new MyICommand(OnAddUcenik);
            ChangeUcenikCommand = new MyICommand(OnChangeUcenik);
            DeleteUcenikCommand = new MyICommand(OnDeleteUcenik);

            AddOdeljenjeCommand = new MyICommand(OnAddOdeljenje);
            ChangeOdeljenjeCommand = new MyICommand(OnChangeOdeljenje);
            AddRazrednogCommand = new MyICommand(OnAddRazredni);
            AddNastavnikCommand = new MyICommand(OnAddNastavnik);
            DeleteOdeljenjeCommand = new MyICommand(OnDeleteOdeljenje);

            AddPredmetCommand = new MyICommand(OnAddPredmet);
            AddOblastCommand = new MyICommand(OnAddOblast);
            ChangeOblastCommand = new MyICommand(OnChangeOblast);
        }

        public void OnAddZaposleni()
        {
            new AddZaposleniWindow(false).ShowDialog();
            OnChange();
        }

        public void OnAddPredmet()
        {
            new AddPredmetWindow(null).ShowDialog();
            OnChange();
        }

        public void OnAddUcenik()
        {
            new AddUcenikWindow(null).ShowDialog();
            OnChange();
        }

        public void OnChangeUcenik()
        {
            if (SelectedUcenik != null)
            { 
                new AddUcenikWindow(SelectedUcenik).ShowDialog();
                OnChange();
            }
            else
            {
                MessageBox.Show("Izaberite učenika prvo!", "Greška!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        public void OnDeleteUcenik()
        {
            if (SelectedUcenik != null)
            {
                if (Channel.Instance.UceniciProxy.DeleteUcenik(SelectedUcenik.Id_ucenika))
                {
                    MessageBox.Show("Učenik obrisan.", "Operacija uspešna!", MessageBoxButton.OK, MessageBoxImage.Information);
                    OnChange();

                }
                else
                {
                    MessageBox.Show("Greška pri brisanju.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                SelectedUcenik = null;                
            }
            else
            {
                MessageBox.Show("Izaberite učenika prvo!", "Greška!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        public void OnDeleteZaposleni()
        {
            if(SelectedZaposleni != null)
            {
                if (Channel.Instance.ZaposleniProxy.DeleteZaposleni(SelectedZaposleni.Id_zaposlenog))
                {
                    OnChange();
                }
            }
            else
            {
                MessageBox.Show("Molimo selektujte Zaposlenog prvo.", "Greška!", MessageBoxButton.OK);
            }
        }

        public void OnDeleteOdeljenje()
        {
            if (SelectedOdeljenje != null)
            {
                if (Channel.Instance.OdeljenjaProxy.DeleteOdeljenje(SelectedOdeljenje))
                {
                    MessageBox.Show("Odeljenje obrisano.", "Operacija uspešna!", MessageBoxButton.OK, MessageBoxImage.Information);
                    OnChange();
                }
                else
                {
                    MessageBox.Show("Greška pri brisanju.", "Operacija neuspešna!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                SelectedOdeljenje = null;
            }
            else
            {
                MessageBox.Show("Izaberite odeljenje prvo!", "Greška!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        public void OnChangeZaposleni()
        {
            new AddZaposleniWindow(true).ShowDialog();
            OnChange();
        }

        public void OnAddOdeljenje()
        {
            new AddOdeljenjeWindow(SelectedOdeljenje).ShowDialog();
            OnChange();
        }
        public void OnChangeOdeljenje()
        {
            if (SelectedOdeljenje == null)
            {
                MessageBox.Show("Prvo izaberite odeljenje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                new AddOdeljenjeWindow(SelectedOdeljenje).ShowDialog();
                OnChange();
            }
        }
        public void OnAddRazredni()
        {
            new AddRazredniWindow(SelectedOdeljenje, true).ShowDialog();
            OnChange();
        }
        public void OnAddNastavnik()
        {
            new AddRazredniWindow(SelectedOdeljenje, false).ShowDialog();
            OnChange();
        }

        public void OnAddOblast()
        {
            new AddOblastWindow(SelectedPredmet, null).ShowDialog();
            OnChange();
        }

        public void OnChangeOblast()
        {
            new OblastiPredmetaWindow(SelectedPredmet).ShowDialog();
            OnChange();
        }
        public void OnChange()
        {
            try
            {
                LoggedIn = LoggedInZaposleni.Instance;
                Zaposleni = Channel.Instance.ZaposleniProxy.GetZaposleni();
                Ucenici = Channel.Instance.UceniciProxy.GetIcenici();
                Odeljenja = Channel.Instance.OdeljenjaProxy.GetOdeljenja();
                Predmeti = Channel.Instance.PredmetiProxy.GetPredmeti();
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: "+e.Message + "\n\nTrace:\n"+e.StackTrace +"\n\nInner:\n\n"+ e.InnerException);
            }
            
        }


    }
}
