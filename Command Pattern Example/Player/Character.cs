using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class Character
    {
        public Move Move { get; private set; }
        public Jump Jump { get; private set; }
        public Attack Attack { get; private set; }
        public CharacterControl Control { get; private set; }

        public Character()
        {
            Move = new Move();
            Jump = new Jump();
            Attack = new Attack();
            Control = new CharacterControl();
        }
    }
}
