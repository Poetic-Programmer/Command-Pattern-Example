using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class JumpHighCommand : GameControlCommand
    {
        Jump jump;
        public JumpHighCommand(Jump jump)
        {
            this.jump = jump;
        }

        public override void Execute()
        {
            jump.High();
        }
    }
}
