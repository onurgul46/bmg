using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {


            string ad; int u, t;
            Console.WriteLine("İsminizi girin:"); ad = Console.ReadLine();
            u = ad.Length;
            for (int i = 0; i < u; i++)
            {
                t = (int)ad[i] + 10;
                Console.Write((char)t);
            }
            Console.ReadLine();
           
          
               
        }
    }
}
