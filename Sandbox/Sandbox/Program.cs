using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Sandbox;

namespace Sample_01.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Seahorse seahorse = new Seahorse();
            seahorse.Type();
            seahorse.GetOut(65);

            Shell shell = new Shell();
            shell.Type();
            shell.GetOut(33);

            IceCream iceCream = new IceCream();
            iceCream.Type();
            iceCream.GetOut(32);


            Crab crab = new Crab();
            crab.Type();
            crab.GetOut(20);
            


            Console.ReadKey();
        }
    }
}
