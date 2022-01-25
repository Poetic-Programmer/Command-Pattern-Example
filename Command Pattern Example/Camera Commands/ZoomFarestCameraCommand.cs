using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class ZoomFarestCameraCommand : Command
    {
        private Camera camera;

        public ZoomFarestCameraCommand(Camera camera)
        {
            this.camera = camera;
        }

        public override void Execute()
        {
            var zoomDepth = 20;
            camera.Zoom(zoomDepth);

            Console.WriteLine("zooming camera to farest distance");
        }
    }
}
