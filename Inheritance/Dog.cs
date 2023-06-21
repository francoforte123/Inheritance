using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Animal
    {
        override public void speak()
        {
            Console.WriteLine("BAAUU BAAAUUU!!");
        }
    }
}
