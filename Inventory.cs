using System.Collections.Generic;
using System.ComponentModel;

namespace CustomInventories
{
    public class Inventory
    {
        [Description("Affected Class")]
        public int ClassID { get; set; }

        [Description("Slots")]
        public List<Slot> SlotList { get; set; }

        public Inventory()
        {
            ClassID = -1;
            SlotList = new List<Slot>() { new Slot() };
        }
    }
}