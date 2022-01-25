using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class SwitchToPlayerControlCharacterCommand : Command
    {
        private CharacterControl control;

        public SwitchToPlayerControlCharacterCommand(CharacterControl control)
        {
            this.control = control;
        }

        public override void Execute()
        {
            Console.WriteLine("Switching to Player Control.");
            control.SwitchToUserControlType();
        }
    }
}
