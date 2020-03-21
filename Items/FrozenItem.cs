using System;

namespace Iceland_Task
{
    public class FrozenItem : Item
    {
        public FrozenItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateInventory()
        {
            SellIn -= 1;
            Quality = SellIn < 0 ? Quality -= 2 : Quality -= 1;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Frozen Item {SellIn} {Quality}");
        }
    }
}
