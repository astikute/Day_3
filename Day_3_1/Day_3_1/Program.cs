using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funkcija3(6, 7);

            int a = Funkcija4(100, 1);
            Console.WriteLine(a);

            Console.ReadLine();
        }

        static void Funkcija3(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;
            Console.WriteLine(c);
        }

        static int Funkcija4 (int skaitlis1, int skaitlis2)
        {
            return skaitlis1 + skaitlis2;
        }

    }

}
