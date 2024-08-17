using System.Threading.Tasks;

public class TickSystem
{

    private const int ticksPerSecond = 5;

    private static int tick;

    private static bool runTickLoop = true;

    public static async Task StartTickSystem()
    {
        runTickLoop = true;
        while (runTickLoop)
        {
            UpdateTick();

            await Task.Delay(1000 / ticksPerSecond);
        }
    }

    public static void PauseTickSystem()
    {
        if (runTickLoop)
        {
            StopTickSystem();
            Console.WriteLine("Sim Paused......");
        }
        else
        {
            runTickLoop = true;
            StartTickSystem();
            Console.WriteLine("Sim Unpaused......");
        }
    }

    public static void StopTickSystem()
    {
        runTickLoop = false;
    }

    private static void UpdateTick()
    {

        tick++;

        Console.WriteLine("Tick :: " + tick);

    }

}
