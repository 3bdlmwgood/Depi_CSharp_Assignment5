using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Ship:IMoveable
    {
        void IMoveable.MoveForward()
        {
            Console.WriteLine("Ship moves forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship moves backward.");
        }
    }
}
