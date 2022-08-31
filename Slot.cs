namespace CustomInventories
{
    public class Slot
    {
        public int ItemID { get; set; }
        public float Chance { get; set; }
        public int Index { get; set; }

        public Slot()
        {
            ItemID = -1;
            Chance = 100;
            Index = 0;
        }

        public Slot(int itemID, float chance, int index)
        {
            ItemID = itemID;
            Chance = chance;
            Index = index;
        }
    }
}