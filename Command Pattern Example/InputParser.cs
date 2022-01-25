using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class InputParser
    {
        private string input;

        public InputParser(string input)
        {
            this.input = input;
        }

        public CommandType Parse(GameMode gameMode)
        {
            switch(gameMode.Type)
            {
                case GameMode.GameModeType.CHARACTER_CONTROL:
                    return ParseCharacterMode();
                case GameMode.GameModeType.MANAGEMENT:
                    return ParseManagementMode();
                default:
                    throw new NullReferenceException("Nothing to parse");
            }
        }

        public MacroCommandtype ParseUniversalInput()
        {
            if (input == "1")
            {
                return MacroCommandtype.SWTICH_TO_MANAGEMENT_MODE;
            }
            else if (input == "2")
            {
                return MacroCommandtype.SWITCH_TO_CHARACTER_CONTORL_MODE;
            }
            else
            {
                return MacroCommandtype.NONE;
            }
        }

        private CommandType ParseCharacterMode()
        {
            var controlInput = CommandType.NONE;

            if (input == "x" || input == "X")
            {
                controlInput = CommandType.PLAYER_LOW_JUMP;
            }
            if (input == "c" || input == "C")
            {
                controlInput = CommandType.PLAYER_HIGH_JUMP;
            }
            if (input == "f" || input == "F")
            {
                controlInput = CommandType.PLAYER_WEAK_ATTACK;
            }
            if (input == "g" || input == "G")
            {
                controlInput = CommandType.PLAYER_STRONG_ATTACK;
            }
            if (input == "w" || input == "W" || input == "a" || input == "A" || input == "s" || input == "S" || input == "d" || input == "D")
            {
                controlInput = CommandType.PLAYER_MOVE;
            }
            return controlInput;
        }

        private CommandType ParseManagementMode()
        {
            var controlInput = CommandType.NONE;

            if (input == "x" || input == "X")
            {
                controlInput = CommandType.CAMERA_ZOOM_MEDIUM;
            }
            if (input == "c" || input == "C")
            {
                controlInput = CommandType.CAMERA_ZOOM_FAREST;
            }
            if (input == "w" || input == "W" || input == "a" || input == "A" || input == "s" || input == "S" || input == "d" || input == "D")
            {
                controlInput = CommandType.CAMERA_MOVE;
            }
            return controlInput;
        }
    }
}
