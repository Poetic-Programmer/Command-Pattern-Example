using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class MoveCameraCommand : Command
    {
        private Camera camera;

        public MoveCameraCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute()
        {
            var direction = new Vector2 { x = 1, y = 0 };
            camera.Move(direction);

            Console.WriteLine(string.Format("Moving camera in direction [{0}, {1}]", direction.x, direction.y));
        }
    }
}
