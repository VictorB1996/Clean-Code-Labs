using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class ElectronicDuck : Bird
    {
        private bool _isSwitchedOn;

        public override void Quack()
        {
            if (_isSwitchedOn)
            {
                Console.WriteLine("Quack Quack... (in a robot voice)");
            }
        }

        public override void Swim()
        {
            //Console.WriteLine("Try to swim if you dare...");
            throw new NotImplementedException("Eletronic ducks can't swim, they'll break in water!");
        }

        public override void TurnOn()
        {
            _isSwitchedOn = true;
        }

        public override void TurnOff()
        {
            _isSwitchedOn = false;
        }
    }
}