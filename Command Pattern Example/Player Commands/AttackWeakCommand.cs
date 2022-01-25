using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class AttackWeakCommand : Command
    {
        Attack attack;

        public AttackWeakCommand(Attack attack, Command command = null)
        {
            this.attack = attack;
        }

        public override void Execute()
        {
            attack.Weak();
        }
    }
}
