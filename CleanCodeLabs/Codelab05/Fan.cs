using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab05
{
    class Fan : IDevice
    {

        public void TurnOff()
        {
            Console.WriteLine("Fan Turned Off. Stop Spinning...");
        }

        public void TurnOn()
        {
            Console.WriteLine("Fan Turned ON. Spinning...");
        }
    }
}
