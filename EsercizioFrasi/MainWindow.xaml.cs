using System;
using System.Collections.Generic;
using System.IO;
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
            string frase = TxtFrasi.Text;
            frasi.Add(frase);
            TxtFrasi.Clear();
            TxtFrasi.Focus();
            i++;
            if (i >= 5) 
            {
                BtnInserisci.IsEnabled = false;
                BtnStampa.IsEnabled = true;
                BtnOrdina.IsEnabled = true;
                BtnPubblica.IsEnabled = true;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < frasi.Count; i++)
            {
                TxtStampa.Text += $"Posizione {i} : {frasi[i]} \n";
            }
            
        }

        private void BtnOrdina_Click(object sender, RoutedEventArgs e)
        {
            frasi.Sort();
            TxtOrdinato.Clear();
            for (int i = 0; i < frasi.Count; i++)
            {
                TxtOrdinato.Text += $" Posizione {i} : {frasi[i]}\n ";
            }
        }

        private void BtnPubblica_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8))
            {
                for (int i = 0; i < frasi.Count; i++)
                    sw.WriteLine("Posizione { i} : { frasi[i]} \n");
                MessageBox.Show("La lista è stata caricata nel file");
                sw.Flush();
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(file))
                File.Delete(file);
            TxtOrdinato.Text = "";
            TxtStampa.Text = "";
            TxtFrasi.Text = "";
            BtnOrdina.IsEnabled = false;
            BtnPubblica.IsEnabled = false;
            BtnStampa.IsEnabled = false;
        }
    }
}
