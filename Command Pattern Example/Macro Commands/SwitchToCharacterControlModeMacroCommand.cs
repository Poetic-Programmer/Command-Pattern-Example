using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class SwitchToCharacterControlModeMacroCommand : MacroCommand
    {
        GameMode gameMode;
        Command[] commands;

        public SwitchToCharacterControlModeMacroCommand(GameMode gameMode, Command[] commands)
        {
            this.gameMode = gameMode;
            this.commands = commands;
        }

        public override void Execute()
        {
            Console.WriteLine("Switch to Character Control...");
            gameMode.SwitchToCharacterControlMode();
            foreach (Command command in commands)
            {
                command.Execute();
            }
            Console.WriteLine("----------------------");
        }
    }
}
