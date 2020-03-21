using System;

namespace Iceland_Task
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateInventory()
        {
            SellIn -= 1;
            Quality += 1;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Aged Brie {SellIn} {Quality}");
        }
    }
}
