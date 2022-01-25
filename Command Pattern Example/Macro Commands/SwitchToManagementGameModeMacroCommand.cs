using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class SwitchToManagementGameModeMacroCommand : MacroCommand
    {
        GameMode gameMode;
        Command[] commands;

        public SwitchToManagementGameModeMacroCommand(GameMode gameMode, Command[] commands)
        {
            this.gameMode = gameMode;
            this.commands = commands;
        }

        public override void Execute()
        {
            Console.WriteLine("Switching to management mode.");
            gameMode.SwitchToManagementMode();
            foreach(Command command in commands)
            {
                command.Execute();
            }
            Console.WriteLine("--------------------------");
        }
    }
}
