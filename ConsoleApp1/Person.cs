using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Person
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a Person.");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID = {ID} - Name = {Name} - Age = {Age}");
        }
    }
}
