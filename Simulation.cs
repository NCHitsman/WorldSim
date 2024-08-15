

using System.Linq;

public class Simulation
{

    Settlement[] settlements;

    Agent[] agents = [];


    public Simulation(int settlementCount)
    {
        settlements = Enumerable.Range(0, settlementCount).Select(_ => new Settlement()).ToArray();

        int idCounter = 1;

        foreach (Settlement settlement in settlements)
        {
            agents.Concat(Enumerable.Range(1, settlement.populationSize).Select(_ => new Agent(idCounter++, settlement)).ToArray()).ToArray();
        }


        Console.WriteLine("Here 1");
    }

    public void StartSimulation()
    {
        TickSystem.StartTickSystem();
    }

    public void PauseSimulation()
    {
        TickSystem.PauseTickSystem();  //TODO Look into if this can cause a memory leak
    }

    public void EndSimulation()
    {
        TickSystem.StopTickSystem();
    }

    public void PrintSettlementInfo()
    {  // TEMP
        foreach (Settlement settlement in settlements)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Settlement Name: " + settlement.name);
            Console.WriteLine("Settlement Size: " + settlement.size);
            Console.WriteLine("Settlement Population Size: " + settlement.populationSize);
            settlement.PrintStockInfo();
            settlement.PrintEconomyInfo();
            settlement.PrintBookkeeperInfo();
        }
        Console.WriteLine("-------------------------------------");
    }

    public void PrintAgentInfo()
    {  // TEMP
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Number of Agents: " + agents.Length);
        Console.WriteLine("-------------------------------------");
    }


}
