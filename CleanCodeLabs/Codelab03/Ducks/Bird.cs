using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public abstract class Bird
    {
        public abstract void Quack();
        public abstract void Swim();

        public virtual void TurnOn() { }
        public virtual void TurnOff() { }
        
    }
}
