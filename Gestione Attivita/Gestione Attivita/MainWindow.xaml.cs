using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestione_Attivita
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Gestore g = new Gestore();
            g.Activate();
            g.Show();
            Hide();
        }
        //https://www.youtube.com/watch?v=Lg_geJrATrc&ab_channel=FoxLearn tutorial https://stackoverflow.com/questions/1195112/how-can-i-get-the-cpu-temperature http://www.lattepanda.com/topic-f11t3004.html

    }
}
