using System.Collections.Generic;
using static CommodityDataStore;
using System.Linq;

public class Stock
{

    private Dictionary<CommodityList, int> stock;

    public Stock(Dictionary<CommodityList, int> initialStock) {
        stock = initialStock;
    }

    public void AddToStock(CommodityList commodity, int value) {
        stock[commodity] += value;
    }

    public void RemoveFromStock(CommodityList commodity, int value) { // TODO Solve what happens if removed value is > remaining commodity stock
        stock[commodity] -= value;
    }

    public int GetStockAmount(CommodityList commodity) {
        return stock[commodity];
    }

}
