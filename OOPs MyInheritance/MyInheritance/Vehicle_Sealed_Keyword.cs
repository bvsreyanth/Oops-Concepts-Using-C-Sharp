using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritance
{
    internal /*sealed*/ class Vehicle_Sealed_Keyword
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle_Sealed_Keyword  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
}
