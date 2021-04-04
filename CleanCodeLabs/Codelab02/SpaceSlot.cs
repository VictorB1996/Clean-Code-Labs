using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class SpaceSlot : SlotCategory
    {
        public override int FindFreeSlot()
        {
            return new Random().Next() * 100;
        }

        public override void MarkSlotBusy(int resourceId)
        {
            Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        }

        public override void MarkSlotFree(int resourceId)
        {
            Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        }
    }
}
