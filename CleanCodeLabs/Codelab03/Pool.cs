using CleanCodeLabs.Codelab03.Ducks;

namespace CleanCodeLabs.Codelab03
{
    public class Pool
    {
        public void OpenForBusiness(params Bird[] ducks)
        {
            Quack(ducks);
            Swim(ducks);
        }

        private void Quack(Bird[] ducks)
        {
            //foreach (var duck in ducks)
            //{
            //    if (duck.GetType() == typeof(ElectronicDuck))
            //    {
            //        ((ElectronicDuck) duck).TurnOn();
            //    }

            //    duck.Quack();
            //}

            foreach (var duck in ducks)
            {
                duck.TurnOn();
                duck.Quack();
            }

        }

        private void Swim(Bird[] ducks)
        {
            //foreach (var duck in ducks)
            //{
            //    if (duck.GetType() != typeof(ElectronicDuck))
            //    {
            //        duck.Swim();
            //    }
            //}

            foreach(var duck in ducks)
            {
                duck.Swim();
            }
        }
    }
}