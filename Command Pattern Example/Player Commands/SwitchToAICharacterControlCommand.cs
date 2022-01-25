using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class SwitchToAICharacterControlCommand : Command
    {
        CharacterControl control;
        public SwitchToAICharacterControlCommand(CharacterControl control)
        {
            this.control = control;
        }

        public override void Execute()
        {
            Console.WriteLine("Switching to AI Control Mode.");

            control.SwitchToAIControlType();
        }
    }
}
