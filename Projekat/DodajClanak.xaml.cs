using Microsoft.Win32;
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
    /// Interaction logic for DodajClanak.xaml
    /// </summary>
    public partial class DodajClanak : Window
    {
        //TextRange tekst = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);

        public DodajClanak()
        {
            InitializeComponent();

           
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cmbFontColor.ItemsSource = new List<string>() { "Red", "Blue", "Black", "Green", "Yellow", "Purple", "Brown", "Aqua", "Lime", "Cyan" };
        }


        private void tbNaslov_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbNaslov.Text.Trim().Equals("Unesite naslov!"))
            {
                tbNaslov.Text = "";
                tbNaslov.Foreground = Brushes.Black;
            }
        }

        private void tbNaslov_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbNaslov.Text.Trim().Equals(string.Empty))
            {
                tbNaslov.Text = "Unesite naslov!";
                tbNaslov.Foreground = Brushes.LightSlateGray;
            }
        }
        private void tbAutor_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbNaslov.Text.Trim().Equals("Unesite ime autora!"))
            {
                tbNaslov.Text = "";
                tbNaslov.Foreground = Brushes.Black;
            }
        }

        private void tbAutor_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbNaslov.Text.Trim().Equals(string.Empty))
            {
                tbNaslov.Text = "Unesite ime autora!";
                tbNaslov.Foreground = Brushes.LightSlateGray;
            }
        }

        private void tbBroj_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbBroj.Text.Trim().Equals("Unesite broj clanka!"))
            {
                tbBroj.Text = "";
                tbBroj.Foreground = Brushes.Black;
            }
        }

        private void tbBroj_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbBroj.Text.Trim().Equals(string.Empty))
            {
                tbBroj.Text = "Unesite ime autora!";
                tbBroj.Foreground = Brushes.LightSlateGray;
            }
        }
        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();


        }


        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cmbFontSize.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.SelectedItem);
            }
        }

        private void cmbFontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbFontColor.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(ForegroundProperty, cmbFontColor.SelectedItem);
            }

        }
        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    imgDynamic.Source = new BitmapImage(fileUri);
                }
            
        }

        private bool validate()
        {
            bool result = true;

            if (tbNaslov.Text.Trim().Equals(""))
            {
                result = false;
                tbNaslov.BorderBrush = Brushes.Red;
                tbNaslov.BorderThickness = new Thickness(1);
                labelNaslovGreska.Content = "Ne moze biti prazno!";
            }
            else
            {
                tbNaslov.BorderBrush = Brushes.Green;
                labelNaslovGreska.Content = string.Empty;
            }

            if (tbAutor.Text.Trim().Equals(""))
            {
                result = false;
                tbAutor.BorderBrush = Brushes.Red;
                tbAutor.BorderThickness = new Thickness(1);
                labelAutorGreska.Content = "Ne moze biti prazno!";
            }
            else
            {
                tbAutor.BorderBrush = Brushes.Green;
                labelAutorGreska.Content = string.Empty;
            }

            int broj = 0;
            if (tbBroj.Text.Trim().Equals(""))
            {
                labelBrojGreska.Content = "Polje ne sme biti prazno!";
                labelBrojGreska.Foreground = Brushes.Red;
                tbBroj.BorderBrush = Brushes.Red;
                result = false;
            }
            else
            {
                if (!int.TryParse(tbBroj.Text.Trim(), out broj))
                {
                    result = false;
                    tbBroj.Foreground = Brushes.Red;
                    labelBrojGreska.Content = "Nedozvoljen unos!";
                    labelBrojGreska.Foreground = Brushes.Red;
                }
                else
                {
                    tbBroj.Foreground = Brushes.Gray;
                    labelBrojGreska.Content = "";
                    labelBrojGreska.Foreground = Brushes.Gray;
                }
            }

            if (tbKategorija.Text.Trim().Equals(""))
            {
                result = false;
                tbKategorija.BorderBrush = Brushes.Red;
                tbKategorija.BorderThickness = new Thickness(1);
                labelKategorijaGreska.Content = "Ne moze biti prazno!";
            }
            else
            {
                tbKategorija.BorderBrush = Brushes.Green;
                labelKategorijaGreska.Content = string.Empty;
            }

            if (imgDynamic.Source == null)
            {
                result = false;
                btnLoadFromFile.Foreground = Brushes.Red;
                labelSlikaGreska.Content = "Mora biti odabrana slika!";
            }
            else
            {
                btnLoadFromFile.Foreground = Brushes.Gray;
                labelSlikaGreska.Content = string.Empty;

            }
            if (Datum.SelectedDate == null)
            {
                result = false;


                labelDatumGreska.Content = "Unesite datum!";
            }
            else
            {

                labelDatumGreska.Content = string.Empty;
            }

            TextRange tekst = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
            if (tekst.Text.Trim().Equals(""))
            {
                rtbEditor.BorderBrush = Brushes.Red;
                labelTekstGreska.Content = "Mora biti napisan tekst!";
                return false;
            }
            else
            {
                rtbEditor.BorderBrush = Brushes.Gray;
                labelTekstGreska.Content = string.Empty;
            }
            return result;
        }

        private void IzadjiDC_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//dodaj
        {
            if (validate())
            {
                TextRange tekst = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                MainWindow.Turiz.Add(new Turizam.Turiz(Int32.Parse(tbBroj.Text), tbNaslov.Text, (DateTime)Datum.SelectedDate, imgDynamic.Source, tbAutor.Text, tekst.Text, tbKategorija.Text));
                this.Close();

            }
            else
            {
                MessageBox.Show("Polja nisu dobro popunjena", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
    }
}
