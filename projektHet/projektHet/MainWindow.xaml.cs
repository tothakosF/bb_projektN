using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace projektHet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tanulok> sracok = new List<Tanulok>();
        public int hazi;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void megnyit_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog allomanyMegnyitas = new OpenFileDialog();
            allomanyMegnyitas.Filter = "Szöveges állományok (*.txt)|*.txt|Minden állomány (*.*)|*.*";
            if (allomanyMegnyitas.ShowDialog() == true)
            {
                foreach (var item in File.ReadLines(allomanyMegnyitas.FileName))
                {
                    Tanulok tanulo = new Tanulok(item);
                    sracok.Add(tanulo);
                }
            }
            tanulokGrid.ItemsSource = sracok;
            tanulokGrid.AlternatingRowBackground = Brushes.Gray;
            tanulokGrid.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog allomanyMentes = new SaveFileDialog();
            allomanyMentes.Filter = "Szöveges állományok (*.txt)|*.txt|Minden állomány (*.*)|*.*";
            if (allomanyMentes.ShowDialog() == true)
            {
                StreamWriter sw = new StreamWriter(allomanyMentes.FileName);
                foreach (var item in sracok)
                {
                    sw.WriteLine(item.Név + ";" + item.Első + ";" + item.Második + ";" + item.Harmadik + ";" + item.Negyedik + ";" + item.Ötödik + ";" + item.Hatodik + ";" + item.Hetedik + ";" + item.Nyolcadik);
                }
                sw.Close();
            }
        }

        private void haziB_Click(object sender, RoutedEventArgs e)
        {
            hazi = 0;
            foreach (var item in sracok)
            {
                if (item.Első == "")
                {
                    hazi++;
                }
                if (item.Második == "")
                {
                    hazi++;
                }
                if (item.Harmadik == "")
                {
                    hazi++;
                }
                if (item.Negyedik == "")
                {
                    hazi++;
                }
                if (item.Ötödik == "")
                {
                    hazi++;
                }
                if (item.Hatodik == "")
                {
                    hazi++;
                }
                if (item.Hetedik == "")
                {
                    hazi++;
                }
                if (item.Nyolcadik == "")
                {
                    hazi++;
                }
            }
            haziL.Content = hazi.ToString();
        }
    }
}
