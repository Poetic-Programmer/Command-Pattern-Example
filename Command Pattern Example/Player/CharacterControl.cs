using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class CharacterControl
    {
        public enum CharacterControlType
        {
            AI,
            USER
        }

        public CharacterControlType ControlType { get; private set; }

        public CharacterControl()
        {
            ControlType = CharacterControlType.USER;
        }

        public void SwitchToAIControlType()
        {
            ControlType = CharacterControlType.AI;
        }

        public void SwitchToUserControlType()
        {
            ControlType = CharacterControlType.USER;
        }
    }
}
