using System.Collections.Generic;

public class CommodityDataStore {

    public enum CommodityList {
        IronOre,
        IronIngots,
        CopperOre,
        CopperIngots,
        SilverOre,
        SilverIngots,
        GoldOre,
        GoldIngots,
        Wood,
        Wheat,
        Milk
    };

    public Dictionary<CommodityList, float> DefaultCommodityValues = new Dictionary<CommodityList, float>() {
        {CommodityList.CopperOre, 0.3f},
        {CommodityList.CopperIngots, 0.9f},
        {CommodityList.IronOre, 0.6f},
        {CommodityList.IronIngots, 1.8f},
        {CommodityList.SilverOre, 1.0f},
        {CommodityList.SilverIngots, 3.0f},
        {CommodityList.GoldOre, 3.0f},
        {CommodityList.GoldIngots, 9.0f},
        {CommodityList.Wood, 0.5f},
        {CommodityList.Wheat, 0.3f},
        {CommodityList.Milk, 0.2f},
    };

}
