using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritance
{
    internal class Multi_Documents: Interface_IPrintable, Interface_IDisplayable
    {
        public void Print()
        {
            Console.WriteLine("Printing the document.");
        }

        public void Display()
        {
            Console.WriteLine("Displaying the document on the screen.");
        }
    }
}
