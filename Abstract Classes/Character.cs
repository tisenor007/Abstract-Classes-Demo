using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class Character : GameObject
    {
        public Character()
        {
            Console.WriteLine("Character constructed");
        }
    }
}
