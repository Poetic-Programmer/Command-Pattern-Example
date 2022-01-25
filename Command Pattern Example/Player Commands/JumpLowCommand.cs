using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class JumpLowCommand : Command
    {
        Jump jump;
        public JumpLowCommand(Jump jump)
        {
            this.jump = jump;
        }

        public override void Execute()
        {
            jump.Low();
        }
    }
}
