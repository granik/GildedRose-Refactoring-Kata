using System;

namespace GildedRoseKata.Domain;

public class Item
{
    public string Name { get; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    private readonly IUpdateStrategy strategy;

    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
        strategy = ItemStrategyFactory.Create(this);
    }

    public void Update()
    {
        strategy.Update(this);
    }

    public void DecreaseSellIn() => SellIn--;

    public void IncreaseQuality(int amount = 1)
        => Quality = Math.Min(50, Quality + amount);

    public void DecreaseQuality(int amount = 1)
        => Quality = Math.Max(0, Quality - amount);

    public void ResetQuality() => Quality = 0;
}
