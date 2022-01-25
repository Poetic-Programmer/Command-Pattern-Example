using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    class GameController
    {
        Command[] command;
        MacroCommand[] macroCommand;

        public GameController(GameMode gameMode, Character character, Camera camera)
        {
            SetCommands(character, camera);
            SetMacroCommands(gameMode);
        }

        private void SetCommands(Character character, Camera camera)
        {
            command = new Command[Enum.GetValues(typeof(CommandType)).Length];
            command[(int)CommandType.NONE] = new NoCommand();
            command[(int)CommandType.PLAYER_MOVE] = new MoveCommand(character.Move);
            command[(int)CommandType.PLAYER_WEAK_ATTACK] = new AttackWeakCommand(character.Attack);
            command[(int)CommandType.PLAYER_STRONG_ATTACK] = new AttackStrongCommand(character.Attack);
            command[(int)CommandType.PLAYER_LOW_JUMP] = new JumpLowCommand(character.Jump);
            command[(int)CommandType.PLAYER_HIGH_JUMP] = new JumpHighCommand(character.Jump);
            command[(int)CommandType.CAMERA_MOVE] = new MoveCameraCommand(camera);
            command[(int)CommandType.CAMERA_ZOOM_MEDIUM] = new ZoomMediumCameraCommand(camera);
            command[(int)CommandType.CAMERA_ZOOM_FAREST] = new ZoomFarestCameraCommand(camera);
            command[(int)CommandType.ATTACH_CAMERA_TO_PLAYER] = new AttachCameraToCharacterrCommand(character, camera);
            command[(int)CommandType.DETACH_CAMERA_FROM_PLAYER] = new DetachCameraFromCharacterCommand(character, camera);
            command[(int)CommandType.SWITCH_TO_USER_CONTROL] = new SwitchToPlayerControlCharacterCommand(character.Control);
            command[(int)CommandType.SWTICH_TO_AI_CONTROL] = new SwitchToAICharacterControlCommand(character.Control);
        }

        private void SetMacroCommands(GameMode gameMode)
        {
            var characterControlCommands = new Command[]
            {
                command[(int)CommandType.ATTACH_CAMERA_TO_PLAYER],
                command[(int)CommandType.SWITCH_TO_USER_CONTROL]
            };

            var managementControlCommands = new Command[]
            {
                command[(int)CommandType.DETACH_CAMERA_FROM_PLAYER],
                command[(int)CommandType.SWTICH_TO_AI_CONTROL]
            };

            macroCommand = new MacroCommand[Enum.GetValues(typeof(MacroCommandtype)).Length];

            macroCommand[(int)MacroCommandtype.SWITCH_TO_CHARACTER_CONTORL_MODE] =
                new SwitchToCharacterControlModeMacroCommand(gameMode, characterControlCommands);
            macroCommand[(int)MacroCommandtype.SWTICH_TO_MANAGEMENT_MODE] =
                new SwitchToManagementGameModeMacroCommand(gameMode, managementControlCommands);
        }

        public void PressMacroButtom(int slot)
        {
            if (slot < 0 || slot >= macroCommand.Length)
            {
                Console.WriteLine("No Such Macro Command");
                return;
            }

            macroCommand[slot].Execute();
        }

        public void PressButton(int slot)
        {
            if(slot < 0 || slot >= command.Length)
            {
                Console.WriteLine("No Such Command");
                return;
            }

            command[slot].Execute();
        }
    }
}
