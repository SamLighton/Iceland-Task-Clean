using System;

namespace Iceland_Task
{
    abstract public class Item
    {
        public Guid Id = Guid.NewGuid();
        public int SellIn { get; set; }
        private int quality;
        public int Quality
        {
            get { return quality; }
            set
            {
                quality = value <= 0 ? quality = 0 : (value >= 50 ? quality = 50 : quality = value);
            }
        }

        public abstract void UpdateInventory();
        public abstract void DisplayInformation();
    }
}
