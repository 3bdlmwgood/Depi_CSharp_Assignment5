using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Engineer : Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am a Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine($"ID = {ID} - Name ={Name} - Age = {Age} - Field = {Field} - Years Of Experience = {YearsOfExperience}");
        }
    }
}
