using System;

namespace C11_Udemy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Steven";

            var lastName = "Erixon";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            
                
                
            var hello = new string[3] { "john", "aina", "aloha" };
            var formattedNames = string.Join(",", hello);
            Console.WriteLine(formattedNames);

            
        }
    }
}
