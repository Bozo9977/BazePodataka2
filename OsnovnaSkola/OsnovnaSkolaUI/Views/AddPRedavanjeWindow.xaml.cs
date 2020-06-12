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
    /// Interaction logic for AddPRedavanjeWindow.xaml
    /// </summary>
    public partial class AddPRedavanjeWindow : Window
    {
        public AddPRedavanjeWindow(OblastIM oblast, PredavanjeIM predavanje)
        {
            InitializeComponent();
            DataContext = new AddPredavanjeViewModel(oblast, predavanje) { Window = this };
        }
    }
}
