using System;

namespace Iceland_Task
{
    public class ChristmasCracker : Item
    {
        public ChristmasCracker(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public override void UpdateInventory()
        {
            SellIn -= 1;

            Quality = SellIn > 0 && SellIn <= 5
                ? Quality += 3
                : (SellIn > 0 && SellIn <= 10
                    ? Quality += 2
                    : (SellIn > 10
                        ? Quality += 1
                        : Quality += 0));
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Christmas Crackers {SellIn} {Quality}");
        }
    }
}
