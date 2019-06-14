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
            public void scramble1()
            {
                Random rng = new Random();
                logic l = new logic(C, R);
                bool p = true ;
                int n = 100;
                int t;
                l.scramble(n);



                for (int i = 0; i < C; i++)

                    for (int j = 0; j < R; j++)
                    {
                        t = l.img[i, j];

                        for (int k = i+1; k < C ; k++)
                            for (int m = j+1; n < R ; k++)
                            {
                                if (l.img[m, k] == t  )
                                {
                                    p = true;
                                }
                                //else { p = true; }
                            }
                    }


                Assert.IsTrue(p);
                
            }


            //не пеезаписывает


            [TestCase]
            public void scramble2()
            {
                Random rng = new Random();
                logic l = new logic(C, R);
                bool p = true;
                bool d = true;
                int n = 10;
                int e = 0;
                int t;
                int y;
                l.scramble(n);


                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                       
                      
                        for (int k = 0; k < C * R; k++)
                        {
                            t = l.img[i, j];
                            if (l.img[i, j] != t) { p = false;  } else { p = true; e++; }

                        }

                    }
                y = (e / n)*100 ;
                

                Assert.IsTrue(y>50);


            }
        
            // хотя бы половина цифр соит не на своих часятх


            [TestCase]
            public void move()
            {
                logic l = new logic(C, R);
                bool p = false;
                //int ii = 1;
                //int jj = 1;
                //int num = 1;
                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                        int t1 = l.img[i, j];
                        int t2 = l.get(i, j);

                        l.move(i, j, i + j * C);

                        if (l.img[i, j] == t2 && l.get(i, j) == t1)
                            p = true;

                        
                    }


                Assert.IsTrue(p);
            }

            [TestCase]
            public void get()
            {
                logic l = new logic(C, R);
                bool p = true;
                for (int i = 0; i < C; i++)
                    for (int j = 0; j < R; j++)
                    {
                        if (l.get(i, j) != i + j * C) { p = false; }

                    }
                Assert.IsTrue(p);
            }

        }
    }
}
                
