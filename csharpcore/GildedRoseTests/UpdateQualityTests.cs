using System;
using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class UpdateQualityTests
    {
        [Fact]
        public static void can_update_quality_okay()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            };

             var app = new GildedRose(Items);
             app.UpdateQuality();
        }


        [Fact]
        public static void assert_aged_brie_increases_in_quality()
        {
            var item = new Item
            {
                Name = "Aged Brie",
                Quality = 5,
                SellIn = 1
            };
        }

        [Fact]
        public static void quality_is_never_negative()
        {
            
        }


        [Fact]
        public static void assert_quality_less_then_fifty()
        {
            
        }
    }
    
}