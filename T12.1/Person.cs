using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12._1
{
    class Person
    {
        /// <summary>
        /// Person's name
        /// </summary>
        public string name;
        /// <summary>
        /// Person's surname
        /// </summary>
        public string surname;
        /// <summary>
        /// Person's age
        /// </summary>
        public int age;
        /// <summary>
        /// Constructor
        /// </summary>
        public Person() { }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void GetInfo()
        {
            WriteLine($"Name: {name}\nSurname: {surname}\nAge: {age}");
        }
    }
}
