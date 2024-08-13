using System.Collections.Generic;

public class RandomGenerators
{

    private static Random Randomizer = new Random();

    private static List<string> SettlementNames = new List<string> { "Test_Town_1", "Test_Town_2" };

    public enum SettlementSizes
    {
        Small,
        Medium,
        Large
    }

    public static Dictionary<SettlementSizes, float> defaultPopulations = new Dictionary<SettlementSizes, float>
    {
        {SettlementSizes.Small, 50.0f},
        {SettlementSizes.Medium, 100.0f},
        {SettlementSizes.Large, 150.0f},
    };


    public static string GenerateSettlementName()
    {
        int randomInt = Randomizer.Next(0, SettlementNames.Count);

        string settlementName = SettlementNames[randomInt];

        SettlementNames.RemoveAt(randomInt);

        return settlementName;
    }

    public static SettlementSizes GenerateSettlementSize()
    {
        SettlementSizes[] sizes = (SettlementSizes[])Enum.GetValues(typeof(SettlementSizes));
        int index = Randomizer.Next(0, sizes.Length);
        return sizes[index];
    }

    public static int GeneratePopulationSize(SettlementSizes settlementSize) {
        return (int)Math.Floor(defaultPopulations[settlementSize] * ((float)Randomizer.NextDouble() + 0.5));
    }
}
