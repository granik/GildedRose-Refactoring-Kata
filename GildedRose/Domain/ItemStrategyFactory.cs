using GildedRoseKata.Domain.Strategies;

namespace GildedRoseKata.Domain;

public static class ItemStrategyFactory
{
    public static IUpdateStrategy Create(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieStrategy(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassStrategy(),
            "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(),
            _ => new NormalItemStrategy()
        };
    }
}
