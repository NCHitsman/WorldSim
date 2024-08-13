using System.Collections.Generic;
using System.Linq;
using static CommodityDataStore;

public class Economy {

    private Dictionary<CommodityList, float> commodityPrices = new Dictionary<CommodityList, float>(DefaultCommodityValues);

    public Economy(float intialEconomyHealth) {
        foreach (var key in commodityPrices.Keys.ToList()) {
            commodityPrices[key] *= intialEconomyHealth;
        }
    }

    public void AdjustPrice(CommodityList commodity, float adjustmentPercentage) {
        commodityPrices[commodity] *= adjustmentPercentage;
    }

    public float GetCommoditySellPrice(CommodityList commodity, float settlementSupply) {
        return commodityPrices[commodity] / settlementSupply;
    }

    public float GetCommodityBuyPrice(CommodityList commodity, float settlementDemand) {
        return commodityPrices[commodity] * settlementDemand;
    }

}
