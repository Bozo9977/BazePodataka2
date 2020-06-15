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
        public MyICommand UcenikOdeljenjeCommand { get; set; }
        public MyICommand ZaposleniPredmetCommand { get; set; }
        public MyICommand DeletePredmetCommand { get; set; }
        public MyICommand ChangePredmetCommand { get; set; }
        public MyICommand CreatePredavanjeCommand { get; set; }
        public MyICommand ChangePredavanjeCommand { get; set; }
        public MyICommand DeletePredavanjeCommand { get; set; }
        public MyICommand CreateCasCommand { get; set; }
        public MyICommand ChangeCasCommand { get; set; }
        public MyICommand CreateDomaciCommand { get; set; }
        public MyICommand ChangeDomaciCommand { get; set; }
        public MyICommand CreateKontrolniCommand { get; set; }
        public MyICommand OceniCommand { get; set; }

        #endregion

        #region Props
        public Window Window { get; set; }
        public string IsAdmin { get; set; }
        public string  AuthorizeAdmin { get; set; }
        public string  AuthorizeZaposleni { get; set; }
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

        List<PredavanjeIM> predavanja;
        public List<PredavanjeIM> Predavanja 
        {
            get
            {
                return predavanja;
            }
            set
            {
                predavanja = value;
                OnPropertyChanged("Predavanja");
            }
        }

        List<CasIM> casovi;
        public List<CasIM> Casovi 
        {
            get
            {
                return casovi;
            }
            set
            {
                casovi = value;
                OnPropertyChanged("Casovi");
            }
        }

        List<KontrolnaTackaIM> kontrolneTacke;
        public List<KontrolnaTackaIM> KontrolneTacke 
        {
            get
            {
                return kontrolneTacke;
            }
            set
            {
                kontrolneTacke = value;
                OnPropertyChanged("KontrolneTacke");
            }
        }
        public KontrolnaTackaIM SelectedKT { get; set; }
        public CasIM SelectedCas { get; set; }
        public PredavanjeIM SelectedPredavanje { get; set; }
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

        Boolean admin;
        public Boolean Admin
        {
            get 
            {
                return admin;
            }
            set
            {
                admin = value;
                OnPropertyChanged("Admin");
            }
        }
        #endregion

        public MainViewModel()
        {
            LoggedIn = LoggedInZaposleni.Instance;
            if(LoggedInZaposleni.Instance.ime != "admin")
            {
                Admin = false;
                IsAdmin = "Visible";
                AuthorizeAdmin = "Hidden";
                AuthorizeZaposleni = "Visible";
                OnZhangeZaposleni();
            }
            else
            {
                Admin = true;
                IsAdmin = "Hidden";
                AuthorizeAdmin = "Visible";
                AuthorizeZaposleni = "Hidden";
                OnChange();
            }
            


            AddZaposleniCommand = new MyICommand(OnAddZaposleni);
            ChangeInfoCommand = new MyICommand(OnChangeZaposleni);
            DeleteZaposleniCommand = new MyICommand(OnDeleteZaposleni);
            ZaposleniPredmetCommand = new MyICommand(OnDodajPredmet);

            AddUcenikCommand = new MyICommand(OnAddUcenik);
            ChangeUcenikCommand = new MyICommand(OnChangeUcenik);
            DeleteUcenikCommand = new MyICommand(OnDeleteUcenik);
            UcenikOdeljenjeCommand = new MyICommand(OnDodajOdeljenje);

            AddOdeljenjeCommand = new MyICommand(OnAddOdeljenje);
            ChangeOdeljenjeCommand = new MyICommand(OnChangeOdeljenje);
            AddRazrednogCommand = new MyICommand(OnAddRazredni);
            AddNastavnikCommand = new MyICommand(OnAddNastavnik);
            DeleteOdeljenjeCommand = new MyICommand(OnDeleteOdeljenje);

            AddPredmetCommand = new MyICommand(OnAddPredmet);
            DeletePredmetCommand = new MyICommand(OnDeletePredmet);
            ChangePredmetCommand = new MyICommand(OnChangePredmet);
            AddOblastCommand = new MyICommand(OnAddOblast);
            ChangeOblastCommand = new MyICommand(OnChangeOblast);

            CreatePredavanjeCommand = new MyICommand(OnCreatePredavanje);
            ChangePredavanjeCommand = new MyICommand(OnChangePredavanje);
            DeletePredavanjeCommand = new MyICommand(OnDeletePredavanje);

            CreateCasCommand = new MyICommand(OnCreateCas);
            ChangeCasCommand = new MyICommand(OnChangeCas);

            CreateDomaciCommand = new MyICommand(OnCreateDomaci);
            ChangeDomaciCommand = new MyICommand(OnChangeDomaci);

            CreateKontrolniCommand = new MyICommand(OnCreateKontrolni);
            
            
            OceniCommand = new MyICommand(OnOceniRadove);


        }

        public void OnOceniRadove()
        {
            if(SelectedKT != null)
            {
                new OceniRadoveWindow(SelectedKT.Id_kontrolne_tacke).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite kontrolnu tačku.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void OnDodajPredmet()
        {
            new ZaposleniPredmetWindow(SelectedZaposleni).ShowDialog();
            OnChange();
        }

        public void OnDeletePredmet()
        {
            if (SelectedPredmet != null)
            {
                if (Channel.Instance.PredmetiProxy.DeletePredmet(SelectedPredmet.Id_predmeta))
                {
                    MessageBox.Show("Predmet obrisan.", "Uspeh!", MessageBoxButton.OK, MessageBoxImage.Information);
                    OnChange();
                }
                else
                {
                    MessageBox.Show("Greška prilikom brisanja.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Prvo izaberite predmet.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void OnCreatePredavanje()
        {
            if (SelectedPredmet != null)
            {
                new OblastiPredmetaWindow(SelectedPredmet, true, false).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite predmet.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void OnCreateCas()
        {
            if (SelectedPredmet != null)
            {
                new OblastiPredmetaWindow(SelectedPredmet, false, true).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite predmet.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void OnCreateDomaci()
        {
            if(SelectedOdeljenje != null)
            {
                new AddDomaciWindow(SelectedOdeljenje, null).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite odeljenje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
        public void OnChangeDomaci()
        {
            if(SelectedKT.Domaci)
            {
                DomaciIM domaci = Channel.Instance.KTProxy.GetDomaciById(SelectedKT.Id_kontrolne_tacke);
                new AddDomaciWindow(null, domaci).ShowDialog();
            }
            else if (!SelectedKT.Domaci)
            {
                KontrolniIM kontrolni = Channel.Instance.KTProxy.GetKontrolniById(SelectedKT.Id_kontrolne_tacke);
                new AddKontrolniWindow(null, kontrolni).ShowDialog();
            }
            OnZhangeZaposleni();
        }

        public void OnCreateKontrolni()
        {
            if(SelectedOdeljenje != null)
            {
                new AddKontrolniWindow(SelectedOdeljenje, null).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite odeljenje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public void OnChangeCas()
        {
            new AddCasWindow(null, SelectedCas).ShowDialog();
            OnZhangeZaposleni();
        }
        public void OnChangePredavanje()
        {
            if (SelectedPredavanje != null)
            {
                new AddPRedavanjeWindow(null, SelectedPredavanje).ShowDialog();
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite predavanje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void OnDeletePredavanje()
        {
            if (SelectedPredavanje != null)
            {

                if (Channel.Instance.PredavanjaProxy.DeletePredavanje(SelectedPredavanje))
                {
                    MessageBox.Show("Predavanje obrisano.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Greška pri uklanjanju.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                OnZhangeZaposleni();
            }
            else
            {
                MessageBox.Show("Prvo izaberite predavanje.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public void OnChangePredmet()
        {
            if (SelectedPredmet != null)
            {
                new AddPredmetWindow(SelectedPredmet).ShowDialog();
                OnChange();
            }
            else
            {
                MessageBox.Show("Prvo izaberite predmet.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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

        public void OnDodajOdeljenje()
        {
            new UcenikOdeljenjeWindow(SelectedUcenik).ShowDialog();
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
            new OblastiPredmetaWindow(SelectedPredmet, false, false).ShowDialog();
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

        public void OnZhangeZaposleni()
        {
            Predmeti = Channel.Instance.PredmetiProxy.GetPredmetiForZaposleni(LoggedIn.Id_zaposlenog);
            Predavanja = Channel.Instance.PredavanjaProxy.GetPredavanjaForZaposleni(LoggedIn);
            Casovi = Channel.Instance.CasovyProxy.GetCasoviForZaposleni(LoggedIn.Id_zaposlenog);
            KontrolneTacke = Channel.Instance.KTProxy.GetKTForZaposleni(LoggedIn.Id_zaposlenog);
            Odeljenja = Channel.Instance.OdeljenjaProxy.GetOdeljenjaForZaposleni(LoggedIn.Id_zaposlenog);
        }

    }
}
