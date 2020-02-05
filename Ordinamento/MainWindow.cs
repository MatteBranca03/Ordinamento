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

namespace Ordinamento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> Alunni = new List<string>(); 
        public const string FILE = "prova.txt";
        public const string name = null;
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtAlunni.Text;
            Alunni.Add(nome);
            Alunni.Sort();
            txtAlunni.Clear();
            txtRisultato.Clear();
            foreach (string name in Alunni)
                txtRisultato.Text += $"{name}\n";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(FILE,true))
            {
                for(int i = 0, i = Alunni.Count, i=i+1)
                {
                    
                }
            }
            sw.Write($"{name}\n");
        }
    }
}