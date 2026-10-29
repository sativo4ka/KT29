using System;
using System.Collections.Generic;
using System.Text;

namespace KT29
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Собака лает: Гав!");
        }
    }
}
