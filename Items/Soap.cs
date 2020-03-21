using System;

namespace Iceland_Task
{
    public class Soap : Item
    {
        public Soap(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateInventory()
        {
            // No Changes
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"{this.GetType().Name} {SellIn} {Quality}");
        }
    }
}
