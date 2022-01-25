using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class ZoomMediumCameraCommand : Command
    {
        private Camera camera;
        
        public ZoomMediumCameraCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute()
        {
            var zoomDepth = 10;
            camera.Zoom(zoomDepth);

            Console.WriteLine("Zooming camera to medium distance.");
        }
    }
}
