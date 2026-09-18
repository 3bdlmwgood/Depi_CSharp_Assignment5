using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane moves forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane moves backward.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane moves up.");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplane moves down.");
        }
    }
}
