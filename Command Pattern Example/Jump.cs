using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class Jump
    {
        public Jump()
        {

        }

        public void Low()
        {
            Console.WriteLine("performing low jump");
        }
        public void High()
        {
            Console.WriteLine("performing high jump");
        }
    }
}
