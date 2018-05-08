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
            Console.WriteLine(a); //Var ari Console.WriteLine(Funkcija4(100,1))

            Console.Write("Ievadiet 1.vardu: ");
            string name1 = Console.ReadLine();
            Console.Write("Ievadiet 2.vardu: ");
            string name2 = Console.ReadLine();
            Console.Write("Ievadiet 3.vardu: ");
            string name3 = Console.ReadLine();
            Console.WriteLine(Funkcija5(name1, name2, name3));

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

        static string Funkcija5 (string vards1, string vards2, string vards3)
        {
            return vards1 + " " + vards2 + " " + vards3;
        }

    }

}
