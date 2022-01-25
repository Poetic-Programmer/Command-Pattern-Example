using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class Attack
    {
        public Attack()
        {

        }

        public void Weak()
        {
            Console.WriteLine("Performing weak attack");
        }

        public void Strong()
        {
            Console.WriteLine("Performing strong attack");
        }
    }
}
