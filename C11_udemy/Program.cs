using C11_udemy.Math;
using System;

namespace C11_udemy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "Steven";
            p.LastName = "Erixon";
            p.Introduce();

            var c = new Calculator();
            var banan = c.Add(1, 2);
            Console.WriteLine(banan);
        }
    }
}
