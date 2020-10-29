using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    class Mold
    {
        public int Bulk = 100;

        public void GetOut(int amount)
        {
            if (amount < Bulk)
                Console.WriteLine(Bulk - amount);

        }
    }
}
