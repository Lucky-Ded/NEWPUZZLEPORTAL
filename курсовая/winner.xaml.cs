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
using System.IO;

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для winner.xaml
    /// </summary>
    public partial class winner : Window
    {
        public winner()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (name.Text == "")
            {
                MessageBox.Show(" Веведите имя");
            }
            else
            {
                menu menu = new menu();
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", name.Text);
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", "                  ");
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", w1.Content.ToString());
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", "                  ");
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", w2.Content.ToString());
                File.AppendAllText(@"C:\ri87\NEWPUZZLEPORTAL\date1.txt", "\n");

                menu.Show();
                this.Close();
            }
        }

        
    }
}
