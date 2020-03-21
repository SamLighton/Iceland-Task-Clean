using System;

namespace Iceland_Task
{
    public class InvalidItem : Item
    {
        public InvalidItem(int sellIn, int quality)
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
            Console.WriteLine("NO SUCH ITEM");
        }
    }
}
