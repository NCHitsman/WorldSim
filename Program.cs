global using System;

class Program
{

    private static bool runSim = true;

    static void Main()
    {

        Console.WriteLine("Initializing Sim......");

        Simulation activeSimulation = new Simulation(2);

        Console.WriteLine("Press Enter To Start Sim......");

        while (runSim)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            switch (keyInfo.Key)
            {
                // Start, Pause, and End Simulation
                case ConsoleKey.Enter:
                    activeSimulation.StartSimulation(); // TODO fix that it can be started multiple times speeding it up
                    Console.WriteLine("Sim Running......");
                    break;
                case ConsoleKey.Spacebar:
                    activeSimulation.PauseSimulation();
                    break;
                case ConsoleKey.Escape:
                    activeSimulation.EndSimulation();
                    runSim = false;
                    Console.WriteLine("Sim Stopped......");
                    break;

                // Keys to print sim Data (temp solution until UI is made)
                case ConsoleKey.P:
                    activeSimulation.PrintSettlementInfo();
                    break;
                case ConsoleKey.A:
                    activeSimulation.PrintAgentInfo();
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("Insert an Agent Id and press Enter...");
                    bool waitingForValidNumber = true;
                    while (waitingForValidNumber){
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out int number))
                        {
                            activeSimulation.PrintSpecificAgentInfo(number);
                            waitingForValidNumber = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid key pressed.");
                    break;
            }

        }


    }

}
