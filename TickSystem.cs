using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class TickSystem {

    private const int ticksPerSecond = 5;

    private static int tick;

    private static bool tickSystemOn = true;

    public static async Task StartTickSystem(){
        while(tickSystemOn) {
            UpdateTick();

            await Task.Delay(1000 / ticksPerSecond);
        }
    }

    public static void StopTickSystem() {
        tickSystemOn = false;
    }

    private static void UpdateTick(){

        tick++;

        Console.WriteLine("Tick :: " + tick);

    }


}
