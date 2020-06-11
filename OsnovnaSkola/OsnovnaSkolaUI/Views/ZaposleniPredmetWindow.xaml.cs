using OsnovnaSkolaPL.IntermediaryModels;
using OsnovnaSkolaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OsnovnaSkolaUI.Views
{
    /// <summary>
    /// Interaction logic for ZaposleniPredmetWindow.xaml
    /// </summary>
    public partial class ZaposleniPredmetWindow : Window
    {
        public ZaposleniPredmetWindow(ZaposleniIM zaposleni)
        {
            InitializeComponent();
            DataContext = new ZaposleniPredmetViewModel(zaposleni) { Window = this };
        }
    }
}
