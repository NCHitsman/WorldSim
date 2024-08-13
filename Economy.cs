using System.Collections.Generic;
using System.Linq;
using static CommodityDataStore;

public class Economy {

    private Dictionary<CommodityList, float> commodityPrices = new Dictionary<CommodityList, float>(DefaultCommodityValues);

    public Economy(float intialEconomyHealth) {
        foreach (var key in commodityPrices.Keys.ToList()) {
            commodityPrices[key] = (float)Math.Round(commodityPrices[key] * intialEconomyHealth, 1);
        }
    }

    public void AdjustPrice(CommodityList commodity, float adjustmentPercentage) { // find solution for considering settlement stock
        commodityPrices[commodity] *= adjustmentPercentage;
    }

    public float GetCommoditySellPrice(CommodityList commodity) {
        return commodityPrices[commodity];
    }

    public float GetCommodityBuyPrice(CommodityList commodity) {
        return commodityPrices[commodity];
    }

}
