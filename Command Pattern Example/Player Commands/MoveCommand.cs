using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class MoveCommand : Command
    {
        private Move move;
        public MoveCommand(Move move)
        {
            this.move = move;
        }

        public override void Execute()
        {
            move.MoveInDirection(new Vector2 { x = 1, y = 0 });
        }
    }
}
