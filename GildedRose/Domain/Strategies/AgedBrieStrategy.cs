namespace GildedRoseKata.Domain.Strategies;

public class AgedBrieStrategy : IUpdateStrategy
{
    public void Update(Item item)
    {
        item.IncreaseQuality();
        item.DecreaseSellIn();

        if (item.SellIn < 0)
            item.IncreaseQuality();
    }
}
