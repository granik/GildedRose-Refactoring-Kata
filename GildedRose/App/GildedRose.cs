using System.Collections.Generic;
using GildedRoseKata.Domain;

namespace GildedRoseKata.App;

public class GildedRose
{
    private readonly IList<Item> items;

    public GildedRose(IList<Item> items)
    {
        this.items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in items)
            item.Update();
    }
}
