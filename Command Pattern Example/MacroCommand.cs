using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public abstract class MacroCommand : Command
    {
        public override abstract void Execute();
    }
}
