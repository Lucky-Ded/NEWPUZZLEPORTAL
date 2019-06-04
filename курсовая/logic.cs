using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая
{
    class logic
    {
        
                int C;
        int R;

        int[,] img;



        public logic(int C, int R)
        {
            this.C = C;
            this.R = R;

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
}
