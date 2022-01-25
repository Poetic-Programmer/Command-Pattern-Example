using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class NoCommand : Command
    {
        public NoCommand()
        {

        }

        public override void Execute()
        {
            Console.WriteLine("No command performed");
        }
    }
}
