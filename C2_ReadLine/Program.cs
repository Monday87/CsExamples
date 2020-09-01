using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = string.Empty;
            int age;

            Console.Write("Welcome Dude! What's your name?");
            name = Console.ReadLine();

            Console.Write($"{name} sweet :) How old are you man? ");
            //age = int.Parse(Console.ReadLine());

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                //age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again man.");
                Console.WriteLine("How old are you man? ");
                age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            { 
            Console.WriteLine($"Oh Cool man! We are the same age. I am also {age}.");
            }


            Console.WriteLine($"Dude your name contains {name.Length} characters.");
            Console.Write($"{name} where do you live? ");
            var city = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {city}");




        }
    }
}
