using System;

namespace Command_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameSimulation = new GameSimulation();

            while(gameSimulation.Running)
            {
                gameSimulation.Update(0.001f);     
            }
        }

    }
}
