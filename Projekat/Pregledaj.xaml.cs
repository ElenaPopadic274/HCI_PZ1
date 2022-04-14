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
using Turizam;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Pregledaj.xaml
    /// </summary>
    public partial class Pregledaj : Window
    {
        public Pregledaj(int index)
        {
            InitializeComponent();
            NaslovPolje.Content = MainWindow.Turiz[index].naslov;
            AutorPolje.Content = MainWindow.Turiz[index].autor;
            TekstPolje.Content = MainWindow.Turiz[index].tekst;
            imgDynamic.Source = MainWindow.Turiz[index].slika;
        }


        private void Izadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

