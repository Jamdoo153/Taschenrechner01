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
    /// Interaktionslogik für Bildergalerie.xaml
    /// </summary>
    public partial class Bildergalerie : Window
    {
        int i = 1;   //Startwert für Zähler

        public Bildergalerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 11;
            }
            images1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\" + i + ".jpg", UriKind.Absolute));

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 11)
            {
                i = 1;
            }
            images1.Source = new BitmapImage(new Uri(@"C:\Users\Walke\source\Cshrap_WPF_XAML\TASCHENRECHNER\MyFristProject\Images\" + i+ ".jpg",UriKind.Absolute));

        }
    }
}
