global using System;

class Program
{

    private static bool simRunning = false;

    private static bool consoleLoop = true;


    static void Main()
    {

        Console.WriteLine("Initializing Sim......");

        Simulation activeSimulation = new Simulation(2);

        Console.WriteLine("Press Enter To Start Sim......");

        while (consoleLoop)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            switch (keyInfo.Key)
            {
                // Start, Pause, and End Simulation
                case ConsoleKey.Enter:
                    if (!simRunning) {
                        activeSimulation.StartSimulation();
                        simRunning = true;
                        Console.WriteLine("Sim Running......");
                    } else {
                        Console.WriteLine("Sim Already Running......");
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (simRunning){
                        activeSimulation.PauseSimulation();
                        simRunning = false;
                    } else {
                        activeSimulation.PauseSimulation();
                        simRunning = true;
                    }
                    break;
                case ConsoleKey.Escape:
                    activeSimulation.EndSimulation();
                    consoleLoop = false;
                    simRunning = false; // Just a formality
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
