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

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для svoboda.xaml
    /// </summary>
    public partial class svoboda : Window
    {
        public svoboda()
        {
            InitializeComponent();
        }

        private void B13_Click(object sender, RoutedEventArgs e)
        {
            Window menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
