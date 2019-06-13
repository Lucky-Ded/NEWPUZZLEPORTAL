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
using System.Windows.Threading;

namespace курсовая
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Dictionary<string, DateTime> dlist = new Dictionary<string, DateTime>();
        int C = 4;
        int R = 4;

        int W = 64;
        int H = 64;
        int[,] num;
        const int N = 16 ;
        logic l;

        Rectangle[] shapes;

        public int h = 0;

        BitmapImage img;

        Rectangle link = null;
        public int g = 0;
        Rectangle lol = new Rectangle();
        Rectangle raz = new Rectangle();
        int oldX = -1;
        int oldY = -1;

        public Window1(BitmapImage image)
        {
            InitializeComponent();
            img = image;
            W = (int)(img.PixelWidth / C);
            H = (int)(img.PixelHeight / R);
            
            //установка цвета линии обводки и цвета заливки при помощи коллекции кистей
            raz.Stroke = Brushes.Black;
            //raz.Fill = Brushes.PaleVioletRed;
            //параметры выравнивания
            raz.HorizontalAlignment = HorizontalAlignment.Left;
            raz.VerticalAlignment = VerticalAlignment.Center;
            //размеры прямоугольника
            raz.Height = img.Height;
            raz.Width = img.Width;
            //добавление объекта в сцену
            desk.Children.Add(raz);


        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timer.Content = h++;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DispatcherTimer dtClockTime = new DispatcherTimer();

            dtClockTime.Tick += dispatcherTimer_Tick;
            dtClockTime.Interval = new TimeSpan(0, 0, 1);
            dtClockTime.Start();

            shapes = new Rectangle[N];

            l = new logic(C, R);
            l.scramble(100);

            desk.Children.Clear();
            desk.Children.Add(raz);

            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    int ind = l.get(i, j);

                    shapes[ind] = new Rectangle();
                    shapes[ind].Tag = ind;
                   
                    ImageBrush ib = new ImageBrush();
                    //позиция изображения будет указана как координаты левого верхнего угла
                    //изображение будет выведено без растяжения/сжатия
                    ib.AlignmentX = AlignmentX.Left;
                    ib.AlignmentY = AlignmentY.Top;
                    ib.Stretch = Stretch.None;
                    //участок изображения который будет нарисован
                    //в данном случае, второй кадр первой строки

                    int py = ind / C;
                    int px = ind - (py * C);

                    ib.Viewbox = new Rect(px * W, py * H, px * W + W, py * H + H);

                    ib.ViewboxUnits = BrushMappingMode.Absolute;

                    //загрузка изображения и назначение кисти
                    ib.ImageSource = img;
                    shapes[ind].Fill = ib;
                    //толщина и цвет обводки
                    shapes[ind].StrokeThickness = 2;
                    shapes[ind].Stroke = Brushes.Black;
                    //размеры овала
                    shapes[ind].Width = W;
                    shapes[ind].Height = H;
                    //позиция овала
                    //shapes[i].Margin = new Thickness(0, 0, 0, 0);


                    shapes[ind].RenderTransform = new TranslateTransform(i * W, j * H);

                    //добавление овала в сцену
                    desk.Children.Add(shapes[ind]);

                    shapes[ind].MouseDown += MainWindow_MouseDown;
                    shapes[ind].MouseUp += MainWindow_MouseUp;
                }
        }


        private void MainWindow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
            Point pos = Mouse.GetPosition(desk);
            
            if (link != null)
            {
                
                if ((pos.X < img.Width) && (pos.Y < img.Height))
                {
                   
                    int x = ((int)pos.X / W) * W;
                    int y = ((int)pos.Y / H) * H;

                   
                    int cX = (int)(x / W);
                    int cY = (int)(y / H);

                    int ind = l.get(cX, cY);


                    shapes[ind].RenderTransform = new TranslateTransform(oldX * W, oldY * H);
                  
                    l.move(oldX, oldY, ind);

                    g = g + 1;
                    hod.Content = g;
                    
                    link.RenderTransform = new TranslateTransform(x, y);

               

                    if (l.move(cX, cY, int.Parse(link.Tag.ToString())))
                    {

                        // MessageBox.Show("win win");
                        winner winner = new winner();
                        winner.w1.Content = timer.Content;
                        winner.w2.Content = hod.Content;
                        winner.Show();
                        this.Close();
                    }
                
                }
                else link.RenderTransform = new TranslateTransform(oldX * W, oldY * H);

               
            }

            link = null;
            // ll.Content = "null";
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {

           
                Point pos = Mouse.GetPosition(desk);
                if ((pos.X < img.Width) && (pos.Y < img.Height))
                {

                    oldX = ((int)pos.X / W);
                    oldY = ((int)pos.Y / H);
                }
           
                link = (Rectangle)sender;

                desk.Children.Remove(link);
                desk.Children.Add(link);
            

            
            
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (link != null)
            {
                Point pos = Mouse.GetPosition(desk);

                link.RenderTransform = new TranslateTransform(pos.X, pos.Y);


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            instruc instruc = new instruc();
            instruc.Show();

        }
    }
}