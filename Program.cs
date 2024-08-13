global using System;
using System.Threading.Tasks;

class Program {

    static void Main() {

        Console.WriteLine("Starting Sim, Press any button to turn off......");

        TickSystem.StartTickSystem();

        Console.ReadKey();

        TickSystem.StopTickSystem();

    }

}
