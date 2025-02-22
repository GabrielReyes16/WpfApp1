﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }
    }
}