using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Turizam;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataIO serializer = new DataIO();
        public static BindingList<Turizam.Turiz> Turiz { set; get; }
        public MainWindow()
        {
            Turiz = serializer.DeSerializeObject<BindingList<Turizam.Turiz>>("turiz.xml");
            if (Turiz == null)
            {
                Turiz = new BindingList<Turizam.Turiz>();
            }
            DataContext = this;
            InitializeComponent();
        }

      

        private void DodajClanak_Click(object sender, RoutedEventArgs e)
        {
            DodajClanak dodajc = new DodajClanak();
            dodajc.ShowDialog();
        }

        private void IzadjiMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Brisanje(object sender, RoutedEventArgs e)
        {
            Turiz.RemoveAt(dataGridTurizam.SelectedIndex);
        }

        private void Izmena(object sender, RoutedEventArgs e)
        {
            Izmeni izmeni = new Izmeni(dataGridTurizam.SelectedIndex);
            izmeni.ShowDialog();
            dataGridTurizam.Items.Refresh();
        }
        private void Pregledaj(object sender, RoutedEventArgs e)
        {
            Pregledaj pregled = new Pregledaj(dataGridTurizam.SelectedIndex);
            pregled.ShowDialog();
        }

        private void save(object sender, CancelEventArgs e)
        {

            serializer.SerializeObject<BindingList<Turizam.Turiz>>(Turiz, "turiz.xml");
        }
    }
}
