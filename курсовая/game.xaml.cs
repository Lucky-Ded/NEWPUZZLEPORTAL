﻿using Microsoft.Win32;
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

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для game.xaml
    /// </summary>
    public partial class game : Window
    {
        int C;
        int R;
        int N;
        public game()
        {
            InitializeComponent();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Window menu = new menu();
            menu.Show();
            this.Close();
        }

        BitmapImage img1 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/enot.jpg", UriKind.Absolute));
        BitmapImage img2 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/gtr.jpg", UriKind.Absolute));
        BitmapImage img3 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ironman.jpg", UriKind.Absolute));
        BitmapImage img4 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/koleso.jpg", UriKind.Absolute));
        BitmapImage img5 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/lestnisa.jpg", UriKind.Absolute));
        BitmapImage img6 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/minecraft.jpg", UriKind.Absolute));
        BitmapImage img7 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/oblako.jpg", UriKind.Absolute));
        BitmapImage img8 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/popug.jpg", UriKind.Absolute));
        BitmapImage img9 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/priroda.jpg", UriKind.Absolute));
        BitmapImage img10 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ris.jpg", UriKind.Absolute));
        BitmapImage img11 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/rjd.jpg", UriKind.Absolute));
        BitmapImage img12 = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/sdohni.jpg", UriKind.Absolute));
        BitmapImage img13;
        
        private void Bim1_Click(object sender, RoutedEventArgs e)
        {
            //добавление объекта в сцену
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img1, C, R, N);
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/enot.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }







        }

        public void Bim2_Click(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img2, C, R, N);
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/gtr.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img3, C, R, N);

                // window1.Nomer = 3;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ironman.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }
        }
        private void First_Click(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img4, C, R, N);

                //  window1.Nomer = 4;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/koleso.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img5, C, R, N);

                //  window1.Nomer = 5;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/lestnisa.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img6, C, R, N);

                // window1.Nomer = 6;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/minecraft.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img7, C, R, N);

                //window1.Nomer = 7;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/oblako.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img8, C, R, N);
                // window1.Nomer = 8;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/popug.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img9, C, R, N);

                //   window1.Nomer = 9;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/priroda.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img10, C, R, N);

                // window1.Nomer = 10;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/ris.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img11, C, R, N);
                //  window1.Nomer = 11;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/rjd.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();

            }
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img12, C, R, N);
                //  window1.Nomer = 12;
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Puzle/for game/sdohni.jpg", UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void Bat1_Click(object sender, RoutedEventArgs e)
        {
            
            if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
            {

                MessageBox.Show("Выберите размер");
            }
            else
            {
                OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
                open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла

                open_dialog.ShowDialog();
                img13 = new BitmapImage(new Uri(open_dialog.FileName, UriKind.RelativeOrAbsolute));

                if (tri.IsChecked == true && (chet.IsChecked == false) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {

                    C = 3;
                    R = 3;
                    N = 9;


                }
                if ((tri.IsChecked == false) && (chet.IsChecked == true) && (piat.IsChecked == false) && (ten.IsChecked == false))
                {
                    C = 4;
                    R = 4;
                    N = 16;

                }
                if ((tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == true) && (ten.IsChecked == false))
                {

                    C = 5;
                    R = 5;
                    N = 25;
                }
                if ((ten.IsChecked == true) && (tri.IsChecked == false) && (chet.IsChecked == false) && (piat.IsChecked == false))
                {

                    C = 10;
                    R = 10;
                    N = 100;
                }
                Window1 window1 = new Window1(img13, C, R, N);
                Rectangle myRect = new Rectangle();
                ImageBrush ub = new ImageBrush();
                //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
                myRect.Stroke = Brushes.Black;
                //myRect.Fill = Brushes.SkyBlue;
                //РАСКОММЕНТИТЬ
                ub.AlignmentX = AlignmentX.Left;
                ub.AlignmentY = AlignmentY.Top;
                ub.ImageSource = new BitmapImage(new Uri(open_dialog.FileName, UriKind.Absolute));
                myRect.Fill = ub;
                //параметры выравнивания
                myRect.HorizontalAlignment = HorizontalAlignment.Left;
                myRect.VerticalAlignment = VerticalAlignment.Center;
                //размеры прямоугольника
                myRect.Height = 230;
                myRect.Width = 400;
                myRect.Margin = new Thickness(1, 0, 0, 0);
                //добавление объекта в сцену
                window1.pokaz.Children.Add(myRect);
                window1.Show();
                this.Close();
            }
        }
    }
}
