using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class Move
    {
        public Move()
        {

        }

        public void MoveInDirection(Vector2 direction)
        {
            Console.WriteLine(string.Format("Performing move in direction ({0}, {1})", direction.x, direction.y));
        }
    }
}
