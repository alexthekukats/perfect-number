using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sz = 0;
            for (int i = 2; ;i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sz += j;
                    }
                }
                if (i == sz)
                {
                    Console.WriteLine("Ez a szám tökéletes: {0}", sz);
                }
                sz = 0;
            }
        }
    }
}
