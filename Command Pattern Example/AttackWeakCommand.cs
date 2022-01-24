using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class AttackWeakCommand :GameControlCommand
    {
        Attack attack;

        public AttackWeakCommand(Attack attack)
        {
            this.attack = attack;
        }

        public override void Execute()
        {
            attack.Weak();
        }
    }
}
