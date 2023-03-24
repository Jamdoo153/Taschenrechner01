﻿using MyFristProject;
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TASCHENRECHNER taschenrechner = new TASCHENRECHNER();
            taschenrechner.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Schätzenspiel schätzenspiel = new Schätzenspiel();
            schätzenspiel.Show();
            this.Close();
        }
    }
}