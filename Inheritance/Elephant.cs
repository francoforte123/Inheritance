using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Elephant : Animal
    {
        override public void speak()
        {
            Console.WriteLine("Sound Elephant!!");
        }
    }
}
