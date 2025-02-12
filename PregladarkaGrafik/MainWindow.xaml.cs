using Microsoft.Win32;
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

namespace PregladarkaGrafik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Zdjecie> Zdjecia { get; set; } = new List<Zdjecie>();
        public int liczba { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();
            string[] liniePliku = File.ReadAllLines("zdjeciaDokatalogu.txt");
            for (int i = 0; i < liniePliku.Length; i = i + 3)
            {
                string nazwaZdjecia = liniePliku[i];
                int liczbaWyswietlen = int.Parse(liniePliku[i+1]);
                int liczbaPolubien = int.Parse(liniePliku[i + 2]);

                Zdjecia.Add(new Zdjecie(nazwaZdjecia, liczbaWyswietlen, liczbaPolubien));
            }

            wyswietlDane(liczba);
        }
        private void wyswietlDane(int i)
        {
           
            
            zdjecieGlowne.Source = new BitmapImage(new Uri(Zdjecia[i].NazwaZdjecia, UriKind.Relative)); ;
        }

        private void Button_Click_Lewo(object sender, RoutedEventArgs e)
        {
            
            
            liczba--;

            if (liczba <= 0)
            {
                liczba = Zdjecia.Count - 1;
                wyswietlDane(liczba);

            }
            TextBox_LiczbaWyswietlen.Text = "Liczba wyświetleń: " + (++Zdjecia[liczba].LiczbaWyswietlen).ToString();
            wyswietlDane(liczba);
        }

        private void Button_Click_Prawo(object sender, RoutedEventArgs e)
        {
           
            

            liczba++;
            if (liczba >= Zdjecia.Count)
            {

                liczba = 0;
                wyswietlDane(liczba);

            }
            TextBox_LiczbaWyswietlen.Text = "Liczba wyświetleń: " + (++Zdjecia[liczba].LiczbaWyswietlen).ToString();

            wyswietlDane(liczba);
        }

        private void Button_Click_Polubienie(object sender, RoutedEventArgs e)
        {
         
            TextBox_LiczbaPolubien.Text = "Liczba polubień: "+(++Zdjecia[liczba].LiczbaPolubien).ToString();
            
            wyswietlDane(liczba);
        }

        private void Button_Click_Zamknij(object sender, RoutedEventArgs e)
        {
        

            Close();
        }
    }
}
