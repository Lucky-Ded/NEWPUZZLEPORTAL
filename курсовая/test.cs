using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace курсовая
{

    public class Func
    {
        int C=3;
        int R=3;

        int[,] img;

        public void logic(int C, int R)
        {
            img = new int[C, R];

            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    img[i, j] = i + j * C;
                }

        }


        public void scramble(int n)
        {
            Random rng = new Random();

            for (int i = 0; i < n; i++)
            {
                int x1 = rng.Next(C);
                int y1 = rng.Next(R);

                int x2 = rng.Next(C);
                int y2 = rng.Next(R);

                int t = img[x1, y1];
                img[x1, y1] = img[x2, y2];
                img[x2, y2] = t;
            }

        }

        public int get(int i, int j)
        {
            return img[i, j];
        }

        public bool move(int ii, int jj, int num)
        {

            img[ii, jj] = num;

            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    if (img[i, j] != i + j * C)


                        return false;
                }

            return true;

        }





    }
    [TestFixture]
    public class Test
    {
        int C = 3;
        int R = 3;

        int[,] img;

        [TestCase]
        public void logic()
        {
            img = new int[C, R];
            bool p = false;
            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    if (img[i, j] == i + j * C) { p = true; }
                }
            Assert.IsTrue(p);
        }




        [TestCase]
        public void scramble()
        {
            Func f = new Func();
            Random rng = new Random();
            int C = 3;
            int R = 3;
            int[,] img;
            int n = 100;
            bool p = false;
            img = new int[C, R];
            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    for (int q = 0; q < n; q++)
                    {
                        img[i, j] = i + j * C;
                        int x1 = rng.Next(C);
                        int y1 = rng.Next(R);

                        int x2 = rng.Next(C);
                        int y2 = rng.Next(R);

                        int t = img[x1, y1];
                        img[x1, y1] = img[x2, y2];
                        img[x2, y2] = t;
                        if (img[i, j] != img[x2, y2]) { p = true; }
                    }
                   
                }
            Assert.IsTrue(p);
        }



            [TestCase]
        public void move()
        {
            Func f = new Func();
            bool p = false;
            int ii=1;
            int jj=1;
            int num=1;

            img[ii, jj] = num;
            for (int i = 0; i < C; i++)
                for (int j = 0; j < R; j++)
                {
                    if (img[i, j] != i + j * C) { p = true; }
                }
            Assert.IsTrue(p);
        }
    }
 }
