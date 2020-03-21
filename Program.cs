using System;
using System.Collections.Generic;
using Iceland_Task;

namespace Iceland_Task
{
    class Program
    {
        public static List<Item> ItemInventory = new List<Item>
        (){
            new AgedBrie(1,1),
            new ChristmasCracker(-1,2),
            new ChristmasCracker(9,2),
            new Soap(2,2),
            new FrozenItem(-1,55),
            new FrozenItem(2,2),
            new InvalidItem(2,2),
            new FreshItem(2,2),
            new FreshItem(-1,5),
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Expected Output");
            foreach (Item item in ItemInventory)
            {
                item.UpdateInventory();
                item.DisplayInformation();
            }
        }
    }
}
