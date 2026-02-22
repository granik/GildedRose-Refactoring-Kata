using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.App;
using GildedRoseKata.Domain;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        Item[] items = [
            new Item("foo", 0, 0)
        ];
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.Equal("foo", items[0].Name);
    }
}