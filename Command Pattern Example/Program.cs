using System;

namespace Command_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            while(!quit)
            {
                PrintOptions();
                var input = GetInput();
                if(HasQuit(input))
                {
                    quit = true;
                    break;
                }

                var parsedInput = ParseInput(input);
                ControlExample(parsedInput);
            }
        }

        static void ControlExample(GameControllerInputType gameControllerInputType)
        {
            var character = new Character();
            var controller = new GameController();

            GameControlCommand command;
            switch (gameControllerInputType)
            {
                case GameControllerInputType.MOVE:
                    command = new MoveCommand(character.Move);                  
                    break;
                case GameControllerInputType.LOW_JUMP:
                    command = new JumpLowCommand(character.Jump);
                    break;
                case GameControllerInputType.HIGH_JUMP:
                    command = new JumpHighCommand(character.Jump);
                    break;
                case GameControllerInputType.WEAK_ATTACK:
                    command = new AttackWeakCommand(character.Attack);
                    break;
                case GameControllerInputType.STRONG_ATTACK:
                    command = new AttackStrongCommand(character.Attack);
                    break;
                case GameControllerInputType.NONE:
                    command = new NoCommand();
                    break;
                default:
                    command = null;
                    break;
            }
            controller.SetCommand(command);
            controller.PressButton();
        }

        static void PrintOptions()
        {
            Console.WriteLine("Controls");
            Console.WriteLine("Move: WASD, Low Jump: X, High Jump: C, Weak Attack: F, Strong Attack: G, Quit: Q");
        }

        static string GetInput()
        {
            Console.Write("Input: ");
            return Console.ReadLine().ToString();     
        }

        static bool HasQuit(string input)
        {
            return (input == "q" || input == "Q");
        }
        static GameControllerInputType ParseInput(string input)
        {
            var controlInput = GameControllerInputType.NONE;

            if(input == "x" || input == "X")
            {
                controlInput = GameControllerInputType.LOW_JUMP;
            }
            if (input == "c" || input == "C")
            {
                controlInput = GameControllerInputType.HIGH_JUMP;
            }
            if (input == "f" || input == "F")
            {
                controlInput = GameControllerInputType.WEAK_ATTACK;
            }
            if (input == "g" || input == "G")
            {
                controlInput = GameControllerInputType.STRONG_ATTACK;
            }
            if(input == "w" || input == "W" || input == "a" || input == "A" || input == "s" || input == "S" || input == "d" || input == "D")
            {
                controlInput = GameControllerInputType.MOVE;
            }
            return controlInput;
        }
    }
}
