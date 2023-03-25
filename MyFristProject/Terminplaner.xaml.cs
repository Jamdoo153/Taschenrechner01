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
    /// Interaktionslogik für Terminplaner.xaml
    /// </summary>
    public partial class Terminplaner : Window
    {
        public Terminplaner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string ausgabeText = erstelleText();  // Hole die Eingabe von Nutzer ab
            listBox1.Items.Add(ausgabeText);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        private string erstelleText()
        {
            string aufgabe = textBox1.Text;
            string person = textBox2.Text;
            string deadline = datePicker1.SelectedDate.ToString();

            string ausgabeText = aufgabe + " | " + person + " | " + deadline;
            return ausgabeText;
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Blue);
            button1.FontSize = 20;
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            button1.Background = Brushes.LightGray;
            button1.Foreground = Brushes.Black;
            button1.FontSize = 18;
        }


        private void button2_MouseEnter(object sender, MouseEventArgs e)
        {
            button2.Foreground = new SolidColorBrush(Colors.Blue);
            button2.FontSize = 20;
        }

        private void button2_MouseLeave(object sender, MouseEventArgs e)
        {
            button2.Background = Brushes.LightGray;
            button2.Foreground = Brushes.Black;
            button2.FontSize = 18;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string nachtrichText = "Willst du den Eintrag wirklich löschen?";
            string nachtrichtTitel = "Du hast auf den folgenden Eintrag doppelgeklickt: " + listBox1.SelectedItem.ToString();
            MessageBoxButton messageBoxButton = MessageBoxButton.YesNo;
            MessageBoxImage messageBoxImage = MessageBoxImage.Hand;
            MessageBoxResult result = MessageBox.Show(nachtrichText, nachtrichtTitel, messageBoxButton, messageBoxImage);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Der Eintrag wurde in die gelöscht Liste verschoben", "YES");
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Du kehrst zum Menu zurück", "NO");
                    break;
            }
        }
    }
}
