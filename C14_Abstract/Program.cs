using C14_Abstract_1.Models;
using System;
using System.Collections.Generic;

namespace C14_Abstract_1
{

    //FIXA FRÅN GITHUB
    class Program
    {
        static void Main(string[] args)
        {

            var classlist = new List<Person>()
            {
                new Teacher { FirstName  = "Steven", LastName = "Erixon", Role = "Teacher" },
                new Student { FirstName = "Anna", LastName = "Andersson"},
                new Student {FirstName = "Håkan", LastName = "Karlsson"}



            };
            
            foreach(var person in classlist)
            {
                if(person is Teacher teacher)
                    Console.WriteLine(${teacher.FirstName) {teacher.LastName - { teacher.Role}");
                    else
                            Console.WriteLine(${
                            teacher.FirstName) {
                                teacher.LastName - { teacher.Role}







                            }

                        }
    }

