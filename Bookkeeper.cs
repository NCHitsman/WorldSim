using System.Linq;
using static CommodityDataStore;
using System.Collections.Generic;

public class Bookkeeper {

    private Dictionary<CommodityList, int> commodityUsagePerTick = ((IEnumerable<CommodityList>)Enum.GetValues(typeof(CommodityList))).ToDictionary(x => x, _ => 0);

    public void updateCommodityUsage(CommodityList commodity, int updateAmount) {
        commodityUsagePerTick[commodity] += updateAmount;
    }

    public int getCommodityUsagePerTick(CommodityList commodity){
        return commodityUsagePerTick[commodity];
    }

}
