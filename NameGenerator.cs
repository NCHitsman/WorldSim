using System.Collections.Generic;

public class NameGenerator
{

    private static List<string> SettlementNames = new List<string> { "Test_Town_1", "Test_Town_2" };

    private static Random Randomizer = new Random();


    public static string GenerateSettlementName()
    {
        int randomInt = Randomizer.Next(0, SettlementNames.Count);

        string settlementName = SettlementNames[randomInt];

        SettlementNames.RemoveAt(randomInt);

        return settlementName;
    }
}
