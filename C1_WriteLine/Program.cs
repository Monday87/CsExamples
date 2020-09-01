using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Steven";
            int age = 33;
            var city = "Örebro";

            

            var text1 = "Welcome Steven. You are 33 years old right? Steven do you live in Örebro?";

            var text2 = "Welcome "+ name +". You are "+ age +" years old right? "+ name +" do you live in "+ city +"?";
            var text3 = String.Format("Welcome {0}. You are {1} years old right? {0} do you live in {2}?", name, age, city);
            var text4 = $"Welcome {name}. You are {age} years old right? {name} do you live in {city}";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
        }
}
}

