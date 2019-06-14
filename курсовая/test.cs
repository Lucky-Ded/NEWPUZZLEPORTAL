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
        [TestFixture]
        public class Test
        {
            int C = 3;
            int R = 3;

            int[,] img;

            [TestCase]
            public void logic()
            {
                logic l = new logic(C, R);           
                bool p = true;
                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                        if (l.img[i, j] != i + j * C) { p = false; }
                    }
                Assert.IsTrue(p);
            }




            [TestCase]
            public void scramble()
            {
                Random rng = new Random();
                logic l = new logic(C, R);
                bool p = false;
                int n = 100;
                l.scramble(n);
                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                        l.img[i, j] = i + j * C;
                        for (int q = 0; q < n; q++)
                        {
                            int x1 = rng.Next(C);
                            int y1 = rng.Next(R);

                            int x2 = rng.Next(C);
                            int y2 = rng.Next(R);

                            int t = l.img[x1, y1];
                            l.img[x1, y1] = l.img[x2, y2];
                            l.img[x2, y2] = t;


                            if (l.img[i, j] != l.img[x2, y2]) { p = true; }
                            
                        }
                        Assert.IsTrue(p);
                    }
                
            }



            [TestCase]
            public void move()
            {
                logic l = new logic(C, R);
                bool p = false;
                int ii = 1;
                int jj = 1;
                int num = 1;
                l.move(ii,jj,num);
                l.img[ii, jj] = num;
                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                        l.img[i, j] = i + j * C;
                        if(l.img[i,j] != l.img[ii,jj]){ p = true; }
                    }
                Assert.IsTrue(p);
            }
        }
    }
}
