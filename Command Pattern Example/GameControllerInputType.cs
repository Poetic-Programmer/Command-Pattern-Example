using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public enum CommandType
    {
        NONE,

        PLAYER_WEAK_ATTACK,
        PLAYER_STRONG_ATTACK,    
        PLAYER_LOW_JUMP,
        PLAYER_HIGH_JUMP,
        PLAYER_MOVE,

        CAMERA_MOVE,
        CAMERA_ZOOM_MEDIUM,
        CAMERA_ZOOM_FAREST,

        ATTACH_CAMERA_TO_PLAYER,
        DETACH_CAMERA_FROM_PLAYER,

        SWITCH_TO_USER_CONTROL,
        SWTICH_TO_AI_CONTROL,
    }

    public enum MacroCommandtype
    {
        NONE,
        SWTICH_TO_MANAGEMENT_MODE,
        SWITCH_TO_CHARACTER_CONTORL_MODE,
    }
}
