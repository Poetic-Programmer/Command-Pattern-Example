using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class AttackStrongCommand : GameControlCommand
    {
        Attack attack;
        public AttackStrongCommand(Attack attack)
        {
            this.attack = attack;
        }

        public override void Execute()
        {
            attack.Strong();
        }
    }
}
