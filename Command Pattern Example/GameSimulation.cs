using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example
{
    public class GameSimulation
    {
        public bool Running { get; private set; }

        private Character testCharacter;
        private Camera testCamera;
        private GameController testController;
        private GameMode gameMode;
        public GameSimulation()
        {
            Running = true;

            testCharacter = new Character();
            testCamera = new Camera();
            gameMode = new GameMode();

            testController = new GameController(gameMode, testCharacter, testCamera);
        }

        public void Update(float deltaTime)
        {
            PrintOptions();
            var input = GetInput();

            if (HasQuit(input))
                Running = false;

            var inputParser = new InputParser(input);
            var macroCommand = inputParser.ParseUniversalInput();
            if (macroCommand != MacroCommandtype.NONE)
            {
                testController.PressMacroButtom((int)macroCommand);
            }
            else
            {
                var command = inputParser.Parse(gameMode);
                testController.PressButton((int)command);
            }

        }

        private Command GetUserCommand(CommandType gameControllerInputType)
        {
            Command command;
            switch (gameControllerInputType)
            {
                case CommandType.PLAYER_MOVE:
                    command = new MoveCommand(testCharacter.Move);
                    break;
                case CommandType.PLAYER_LOW_JUMP:
                    command = new JumpLowCommand(testCharacter.Jump);
                    break;
                case CommandType.PLAYER_HIGH_JUMP:
                    command = new JumpHighCommand(testCharacter.Jump);
                    break;
                case CommandType.PLAYER_WEAK_ATTACK:
                    command = new AttackWeakCommand(testCharacter.Attack);
                    break;
                case CommandType.PLAYER_STRONG_ATTACK:
                    command = new AttackStrongCommand(testCharacter.Attack);
                    break;
                case CommandType.CAMERA_ZOOM_FAREST:
                    command = new ZoomFarestCameraCommand(testCamera);
                    break;
                case CommandType.CAMERA_ZOOM_MEDIUM:
                    command = new ZoomMediumCameraCommand(testCamera);
                    break;
                case CommandType.CAMERA_MOVE:
                    command = new MoveCameraCommand(testCamera);
                    break;
                case CommandType.NONE:
                    command = new NoCommand();
                    break;
                default:
                    command = null;
                    break;
            }
            return command;
        }

        private void PrintOptions()
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Controls");
            Console.WriteLine("Switch to Management Mode: 1, Switch to Character Control Mode: 2");
            switch (gameMode.Type)
            {
                case GameMode.GameModeType.CHARACTER_CONTROL:
                    Console.WriteLine("Move: WASD, Low Jump: X, High Jump: C, Jump Attack: R, Weak Attack: F, Strong Attack: G");
                    break;
                case GameMode.GameModeType.MANAGEMENT:
                    Console.WriteLine("Move: WASD, Zoom Camera Medium: X, Zoom Camera Farest: C");
                    break;
            }

        }

        private string GetInput()
        {
            Console.Write("Input: ");
            return Console.ReadLine().ToString();
        }

        private bool HasQuit(string input)
        {
            return (input == "q" || input == "Q");
        }
    }
}
