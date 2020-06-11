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
    /// Interaction logic for UcenikOdeljenjeWindow.xaml
    /// </summary>
    public partial class UcenikOdeljenjeWindow : Window
    {
        public UcenikOdeljenjeWindow(UcenikIM ucenik)
        {
            InitializeComponent();
            DataContext = new UcenikOdeljenjeViewModel(ucenik) { Window = this };
        }
    }
}
