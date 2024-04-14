using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritance
{
    //Abstract class
    internal abstract class Abstract_Shape
    {
        public abstract double Area(); // Abstract method 

        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }
}
