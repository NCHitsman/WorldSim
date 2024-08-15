
using System.Linq;
using static CommodityDataStore;
using static RandomGenerators;
using System.Collections.Generic;

public class Settlement
{

    public string name;

    public SettlementSizes size;

    public int populationSize;

    public Stock stock;

    public Economy economy;

    public Bookkeeper bookkeeper;

    public Settlement()
    {

        // Generate random Settlement name
        name = GenerateSettlementName();

        // Randomize the size of the Settlement
        size = GenerateSettlementSize();

        // Randomize the size of the Settlement population
        populationSize = GeneratePopulationSize(size);

        // Setup initial stock numbers
        Dictionary<CommodityList, int> initialStock = ((IEnumerable<CommodityList>)Enum.GetValues(typeof(CommodityList))).ToDictionary(x => x, x => (int)(new Random().NextDouble() * 1000) + 150); // Base of 150 + 001-999

        // Instantiate Stock w/ initial data
        stock = new Stock(initialStock);

        /* Generate a float representing the initial economic health of the settlement
        This will be used by the Economy class by multiplying the prices */
        float initialEconomicHealth = (float)(new Random().NextDouble() + 0.5);

        // Instantiate Economy w/ initial economic health
        economy = new Economy(initialEconomicHealth);

        // Instantiate Bookkeeper
        bookkeeper = new Bookkeeper();
    }

    public void PrintStockInfo()
    { // TEMP
        Console.WriteLine(".    Stock Info --------------||--------------");
        foreach (CommodityList commodity in Enum.GetValues(typeof(CommodityList)))
        {
            Console.WriteLine(".    " + commodity + " Stock: " + stock.GetStockAmount(commodity));
        }
    }

    public void PrintEconomyInfo()
    { // TEMP
        Console.WriteLine(".    Economy Info --------------||--------------");
        foreach (CommodityList commodity in Enum.GetValues(typeof(CommodityList)))
        {
            Console.WriteLine(".    " + commodity + " Economy Buy: " + economy.GetCommodityBuyPrice(commodity));
            Console.WriteLine(".    " + commodity + " Economy Sell: " + economy.GetCommoditySellPrice(commodity));
        }
    }

    public void PrintBookkeeperInfo()
    { // TEMP
        Console.WriteLine(".    Bookkeeper Info --------------||--------------");
        foreach (CommodityList commodity in Enum.GetValues(typeof(CommodityList)))
        {
            Console.WriteLine(".    " + commodity + " Usage Per Tick: " + bookkeeper.getCommodityUsagePerTick(commodity));
        }
    }

}
