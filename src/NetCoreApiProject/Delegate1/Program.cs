using System;

namespace _01.Delegate
{
    class Program
    {
        delegate void Islemler(int num1, int num2);

        static void Main(string[] args)
        {
            Islemler delegateIslemler = new Islemler(Topla);
            delegateIslemler.Invoke(2, 3);
            delegateIslemler = delegateIslemler + Carp;
            delegateIslemler.Invoke(2, 3);
            Console.ReadKey();
        }

        static void Topla(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void Carp(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
    }
}
