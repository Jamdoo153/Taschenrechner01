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

namespace MyFristProject
{
    /// <summary>
    /// Interaktionslogik für Schätzenspiel.xaml
    /// </summary>
    public partial class Schätzenspiel : Window
    {
        int untergrenze = 1;
        int obergrenze = 10;
        bool punktGewinn = false;
        int leben = 10;      //Anzahl der Leben zu begin des Spiels
        bool spieleStatus = false;

        public Schätzenspiel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            spieleSpiel();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            neuStart(); // Diese Methode setzt die Lebenanzahl zurück
        }
        private int generiereZufallZahl(int untergrenze, int obergrenze)
        {
            int zufallZahl = 0;
            Random random = new Random();
            zufallZahl = random.Next(untergrenze, obergrenze); // Eine Zufallzahl zwischen 1-10 wird generiert
            return zufallZahl;
        }

        private bool pruefeErgebnis(int zufallZahl)
        {
            int userEingabe = Convert.ToInt32(textBox1.Text);

            if (zufallZahl != userEingabe)
            {
                punktGewinn = false;
            }
            else
            {
                punktGewinn = true;
            }
            return punktGewinn;
        }

        private void erstelleBild(bool punktGewinn)
        {
            if (punktGewinn == false)
            {
                //MessageBox.Show("Falsch");
                image1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\falsch.jpg", UriKind.Absolute));
                image1.Visibility = Visibility.Visible;
            }
            else
            {
                //MessageBox.Show("Richti)");
                image1.Source = new BitmapImage(new Uri(@"C:\\Users\\Walke\\source\\Cshrap_WPF_XAML\\TASCHENRECHNER\\MyFristProject\\Images\\richtig.jpg", UriKind.Absolute));
                image1.Visibility = Visibility.Visible;
            }
        }


        private int aktualisiereLeben(bool punktGewinn)
        {
            if (punktGewinn == false)
            {
                leben -= 1;
            }
            else
            {
                leben += 5;
            }
            label2.Content = leben;
            return leben;
        }

        private bool spielEnde(int leben)
        {
            bool spielEnde = false;
            if (leben < 1)
            {
                MessageBox.Show("Du hast das Spiel verloren");
                spielEnde = false;
                image1.Visibility = Visibility.Hidden;
            }
            else if (leben > 14) 
            {
                MessageBox.Show("Du hast das Spiel gewonnen");
                spielEnde=true;
                image1.Visibility = Visibility.Hidden;
            }
            return spielEnde;
        }


        private void spieleSpiel()
        {
            int zufallZahl = generiereZufallZahl(untergrenze, obergrenze);
            punktGewinn = pruefeErgebnis(zufallZahl);   // Zeigt falsch oder richtig als Bild an (je nach boolischen Wert)
            erstelleBild(punktGewinn);                  // erstellt das dazu gehörigen Bild
            textBlock4.Text = zufallZahl.ToString();            
            leben = aktualisiereLeben(punktGewinn);     // gibt den aktuellen Leben an 
            spieleStatus = spielEnde(leben);           // prüft, ob das Spiel zu beendet ist
        }

        private void neuStart()
        {
            textBox1.Text = "";
            textBlock4.Text = "";
            leben = 10;
            label2.Content = leben;
        }
    }
}
