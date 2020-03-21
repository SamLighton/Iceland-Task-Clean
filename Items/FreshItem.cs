using System;

namespace Iceland_Task
{
    public class FreshItem : Item
    {
        public FreshItem(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateInventory()
        {
            SellIn -= 1;
            Quality = SellIn < 0 ? Quality -= 4 : Quality -= 2;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Fresh Item {SellIn} {Quality}");
        }
    }
}
