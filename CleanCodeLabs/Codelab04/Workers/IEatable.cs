using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab04.Workers
{
    interface IEatable: IWorker
    {
        string Eat();
    }
}
