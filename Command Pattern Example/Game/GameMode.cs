using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class GameMode
    {
        public enum GameModeType
        {
            CHARACTER_CONTROL,
            MANAGEMENT,
        }

        public GameModeType Type { get; private set; }

        public GameMode()
        {
            Type = GameModeType.CHARACTER_CONTROL;
        }

        public void SwitchToCharacterControlMode()
        {
            Type = GameModeType.CHARACTER_CONTROL;
        }

        public void SwitchToManagementMode()
        {
            Type = GameModeType.MANAGEMENT;
        }
    }
}
