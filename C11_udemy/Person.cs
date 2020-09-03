using System;
using System.Collections.Generic;
using System.Text;

namespace C11_udemy
{
    public class Person
    {

        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi my name is " + FirstName + " " + LastName);
        }


    }
}

