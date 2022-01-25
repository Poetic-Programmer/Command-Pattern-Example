using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class AttachCameraToCharacterrCommand : Command
    {
        private Character character;
        private Camera camera;

        public AttachCameraToCharacterrCommand(Character character, Camera camera)
        {
            this.character = character;
            this.camera = camera;
        }

        public override void Execute()
        {
            Console.WriteLine("Attaching camera to player");
        }
    }
}
