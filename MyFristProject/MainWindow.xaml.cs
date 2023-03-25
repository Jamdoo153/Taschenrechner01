using MyFristProject;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyProject
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

        private void button1_Click1_1(object sender, RoutedEventArgs e)
        {
            TASCHENRECHNER taschenrechner = new TASCHENRECHNER();
            taschenrechner.Show();
        }

        private void button2_Click1_1(object sender, RoutedEventArgs e)
        {
            Schätzenspiel schätzenspiel = new Schätzenspiel();
            schätzenspiel.Show();
        }

        private void button3_Click1_1(object sender, RoutedEventArgs e)
        {
            Bildergalerie bildergalerie = new Bildergalerie();
            bildergalerie.Show();
        }

        private void button4_Click1(object sender, RoutedEventArgs e)
        {
            StimmungBarometer stimmungBarometer = new StimmungBarometer();
            stimmungBarometer.Show();
        }

        private void button5_Click1_1(object sender, RoutedEventArgs e)
        {
            Terminplaner terminplaner = new Terminplaner();
            terminplaner.Show();
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        private void button2_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        private void button3_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        private void button4_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }

        private void button4_MouseLeave_1(object sender, MouseEventArgs e)
        {

        }
        private void button5_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        private void button5_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
