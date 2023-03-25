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
    /// Interaktionslogik für StimmungBarometer.xaml
    /// </summary>
    public partial class StimmungBarometer : Window
    {
        double faktorSchlaf = 1.5;
        double faktorEssen = 0.75;
        double faktorEnergie = 1.25;
        double faktorArbeit = 1;

        public StimmungBarometer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double slider1Valus = slider1.Value;     // speichert aktuellen Wert des jeweiligen Slider
            double slider2Valus = slider2.Value;    
            double slider3Valus = slider3.Value;    
            double slider4Valus = slider4.Value;    

            double summeStimmung =berechneStimmung(slider1Valus, slider2Valus, slider3Valus, slider4Valus);
            bewerteStimmung(summeStimmung);
        }

        private double berechneStimmung(double value1, double value2, double value3, double value4)
        {
            double ergebnis = value1 * faktorSchlaf + value2 * faktorEssen + value3 * faktorEnergie + value4 * faktorArbeit;
            return ergebnis;
        }

        private void bewerteStimmung(double ergebnis)
        {
            if (ergebnis < 150)
            {
                image1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\sad.png", UriKind.Absolute));
                textblock6.Text = ergebnis.ToString();
            }
            else if (ergebnis <=200)
                {
                image1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\neutral.png", UriKind.Absolute));
                textblock6.Text = ergebnis.ToString();
            }
            else
            {
                image1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\smile.png", UriKind.Absolute));
                textblock6.Text = ergebnis.ToString();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            slider1.Value = 0.0;
            slider2.Value = 0.0;
            slider3.Value = 0.0;
            slider4.Value = 0.0;
            image1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\question_mark.png", UriKind.Absolute));

        }
    }
}
