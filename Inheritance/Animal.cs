using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance{

    internal class Animal{

        public String nameAnimal = " ";
        public int age = 0;

        virtual
        public void speak() {
            Console.WriteLine("Sound Animal Generic!!");
        }

    }
}
