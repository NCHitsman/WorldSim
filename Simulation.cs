

using System.Linq;

public class Simulation {

    Settlement[] settlements;


    public Simulation(int settlementCount) {
        settlements = Enumerable.Range(0, settlementCount).Select(_ => new Settlement()).ToArray();
    }


    public void StartSimulation() {
        TickSystem.StartTickSystem();
    }

    public void PauseSimulation() {
        TickSystem.PauseTickSystem();  //TODO Look into if this can cause a memory leak
    }

    public void EndSimulation() {
        TickSystem.StopTickSystem();
    }

    public void PrintSettlementInfo() {  // TEMP
        foreach (Settlement settlement in settlements) {
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


}
