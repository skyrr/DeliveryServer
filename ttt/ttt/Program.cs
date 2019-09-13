using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3]{
                { 1, 0, 0 },
                { 1, 0, 0 },
                { 0, 0, 1 }
            };

            for (int i = 0; i < 3; i++) {
                for (int y = 0; y < 3; y++) {
                    if (i == y)
                    {
                        if (a[i,y] == 1)
                        {
                            Console.WriteLine("they are equal: " + a[i, y]);
                        }
                    }
                    //Console.WriteLine(a[i, y]);
                }
            }
            Console.Read();
        }
    }
}
