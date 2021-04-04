using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    public abstract class SlotCategory
    {
        

        public abstract void MarkSlotFree(int resourceId);
        public abstract void MarkSlotBusy(int resourceId);
        public abstract int FindFreeSlot();
    }
}
