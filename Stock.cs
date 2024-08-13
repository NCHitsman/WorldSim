using System.Collections.Generic;
using static CommodityDataStore;
using System.Linq;

public class Stock
{

    public Dictionary<CommodityList, int> stock = ((IEnumerable<CommodityList>)Enum.GetValues(typeof(CommodityList))).ToDictionary(x => x, x => 0);

    public void AddToStock(CommodityList commodity, int value) {
        stock[commodity] += value;
    }

    public void RemoveFromStock(CommodityList commodity, int value) { // TODO Solve what happens if removed value is > remaining commodity stock
        stock[commodity] -= value;
    }

}
