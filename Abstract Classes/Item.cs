﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class Item : GameObject
    {
        public Item()
        {
            Console.WriteLine("Item constructed");
        }
    }
}
