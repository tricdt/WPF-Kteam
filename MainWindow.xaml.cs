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

namespace WPF_Kteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Click += btn_Click;
            //btn.Content = "Free Education";
            grdButton.Children.Add(btn);

            //TextBlock txbl = new TextBlock();
            //txbl.Text = "Share to be better";
            //btn.Content = txbl;

            //TextBox txb = new TextBox();
            //txb.Width = 100;
            //txb.Height = 50;
            //btn.Content = txb
        }
        void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("CLick rồi nè!");
        }
    }

}