namespace GildedRoseKata.Domain.Strategies;

public class NormalItemStrategy : IUpdateStrategy
{
    public void Update(Item item)
    {
        item.DecreaseQuality();
        item.DecreaseSellIn();

        if (item.SellIn < 0)
            item.DecreaseQuality();
    }
}