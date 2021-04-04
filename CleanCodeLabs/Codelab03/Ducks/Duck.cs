using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class Duck : Bird
    {
        //public virtual void Quack()
        //{
        //    Console.WriteLine("Quack...");
        //}

        //public virtual void Swim()
        //{
        //    Console.WriteLine("Swim...");
        //}

        public override void Quack()
        {
            Console.WriteLine("Quack...");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}