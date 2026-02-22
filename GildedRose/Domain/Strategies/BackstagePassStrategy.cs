namespace GildedRoseKata.Domain.Strategies;

public class BackstagePassStrategy : IUpdateStrategy
{
    public void Update(Item item)
    {
        item.IncreaseQuality();

        if (item.SellIn < 11)
            item.IncreaseQuality();

        if (item.SellIn < 6)
            item.IncreaseQuality();

        item.DecreaseSellIn();

        if (item.SellIn < 0)
            item.ResetQuality();
    }
}