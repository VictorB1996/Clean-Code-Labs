using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class TimeSlot : SlotCategory
    {
        public override int FindFreeSlot()
        {
            return new Random().Next() * 50;
        }

        public override void MarkSlotBusy(int resourceId)
        {
            Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        }

        public override void MarkSlotFree(int resourceId)
        {
            Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        }
    }
}
