﻿using System;
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
    /// Interaktionslogik für TASCHENRECHNER.xaml
    /// </summary>
    public partial class TASCHENRECHNER : Window
    {
        public TASCHENRECHNER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            float zahl1 = float.Parse(textBox1.Text);
            float zahl2 = float.Parse(textBox2.Text);
            float ergebnis = zahl1 + zahl2;
            textBlock5.Text = ergebnis.ToString();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            float zahl1 = float.Parse(textBox1.Text);
            float zahl2 = float.Parse(textBox2.Text);
            float ergebnis = zahl1 - zahl2;
            textBlock5.Text = ergebnis.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            float zahl1 = float.Parse(textBox1.Text);
            float zahl2 = float.Parse(textBox2.Text);
            float ergebnis = zahl1 * zahl2;
            textBlock5.Text = ergebnis.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            float zahl1 = float.Parse(textBox1.Text);
            float zahl2 = float.Parse(textBox2.Text);
            float ergebnis = zahl1 / zahl2;
            textBlock5.Text = ergebnis.ToString();
        }
    }
}
