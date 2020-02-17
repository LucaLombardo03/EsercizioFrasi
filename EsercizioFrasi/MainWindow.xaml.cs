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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace EsercizioFrasi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string file = "prova.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> frasi = new List<string>();
        int i = 0;
        
        private void Inserisci_Click(object sender, RoutedEventArgs e)
        {
            frasi[i] = TxtFrasi.Text;
            i++;
            TxtFrasi.Clear();
            TxtFrasi.Focus();
            if (i >= 5)
            {
                BtnInserisci.IsEnabled = false;
                BtnStampa.IsEnabled = true;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < frasi.Count; i++)
            {
                LblStringa.Content += $"Posizione {i} : {frasi[i]} \n";
            }
            BtnOrdina.IsEnabled = true;
            BtnPubblica.IsEnabled = true;
        }

        private void BtnOrdina_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
