using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritance
{
    internal class Dog_Using_Instance_Method: Animal_Using_Instance_Method
    {
        public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
    }
}
