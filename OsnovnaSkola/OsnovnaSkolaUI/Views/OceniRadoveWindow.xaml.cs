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
    /// Interaction logic for OceniRadoveWindow.xaml
    /// </summary>
    public partial class OceniRadoveWindow : Window
    {
        public OceniRadoveWindow(int idKT)
        {
            InitializeComponent();
            DataContext = new OceniRadoveViewModel(idKT) { Window = this };
        }
    }
}
