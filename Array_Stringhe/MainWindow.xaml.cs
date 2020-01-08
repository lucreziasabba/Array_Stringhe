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

namespace Array_Stringhe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string file = "file.txt"; 
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] array = new string[5];
        int i = 0;
        private void BtnInserisci_Click(object sender, RoutedEventArgs e)
        {
            array[i] = TxtStringa.Text;
            i++;
            TxtStringa.Clear(); 
            TxtStringa.Focus();
            if (i >= 5)
            {
                BtnStampa.IsEnabled = true;
                BtnPubblica.IsEnabled = true;
                BtnInserisci.IsEnabled = false;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (i = 0; i < array.Length; i++)
            {
                LblStringa.Content += $"Posizione {i} : {array[i]} \n";
            }
        }

        private void BtnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writerfile = new StreamWriter(file, false, Encoding.UTF8);
            for (i = 0; i < array.Length; i++)
            {
                writerfile.WriteLine($" Posizione {i} : {array[i]} \n");
            }
            writerfile.Flush();
            writerfile.Close();
        }
    }
}
