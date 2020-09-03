using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace C10_LearningThis
{
    class Person
    {
        public string name;
        public string lastName;
        public string cocaCola;

        public Person()
        {
            name = "dtiger";
            lastName = "default";
            cocaCola = "coolio";
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.name = "byter namn";
            p.cocaCola = "tjena";
            Console.WriteLine(p.name);


            
            
        
        }

    
    }

}

