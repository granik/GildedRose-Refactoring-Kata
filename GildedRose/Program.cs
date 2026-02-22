using System;
using System.Collections.Generic;
using GildedRoseKata.App;
using GildedRoseKata.Domain;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            
            var items = InitializeItems();
            var app = new GildedRose(items);

            int days = args.Length > 0 ? int.Parse(args[0]) + 1 : 2;

            RunSimulation(app, items, days);
        }

        private static IList<Item> InitializeItems()
        {
            return new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new Item("Conjured Mana Cake", 3, 6)
            };
        }

        private static void RunSimulation(GildedRose app, IList<Item> items, int days)
        {
            for (int day = 0; day < days; day++)
            {
                Console.WriteLine($"-------- day {day} --------");
                PrintItems(items);
                Console.WriteLine();
                app.UpdateQuality();
            }
        }

        private static void PrintItems(IList<Item> items)
        {
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            }
        }
    }
}
