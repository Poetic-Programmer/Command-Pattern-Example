using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class GameController
    {
        GameControlCommand command;

        public GameController()
        {

        }

        public void SetCommand(GameControlCommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }
}
