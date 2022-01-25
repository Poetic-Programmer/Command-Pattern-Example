using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class Camera
    {
        public int ZoomDepth { get; private set; }
        public Vector2 Position { get; private set; }

        public Camera()
        {
            Position = new Vector2();
        }

        public void Move(Vector2 direction)
        {
            Position.x += direction.x;
            Position.y += direction.y;
        }

        public void Zoom(int zoom)
        {
            ZoomDepth = zoom;
        }
    }
}
