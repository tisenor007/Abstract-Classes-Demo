using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Abstract Classes Demo");
            Console.WriteLine();

            //instances
            Player player = new Player();
            Console.WriteLine();
            Enemy enemy = new Enemy();
            Console.WriteLine();
            Shield shield = new Shield();
            Console.WriteLine();
            Weapon weapon = new Weapon();
            //Character character = new Character(); //No need to instanciate character so it is made abstract

            Console.ReadKey(true);
        }
    }
}
