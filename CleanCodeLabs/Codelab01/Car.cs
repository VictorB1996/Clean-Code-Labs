using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CleanCodeLabs.Codelab01
{
    public class Car
    {
        public Car(string id, string model, string brand)
        {
            Id = id;
            Model = model;
            Brand = brand;
        }

        public string Id { get; }
        public string Model { get; }
        public string Brand { get; }

        public string CarName { get
            {
                return $"{Brand} {Model}, ";
        } }

        public Car RetrieveCar(string carId, List<Car> cars)
        {
            return cars.FirstOrDefault(car => car.Id == carId);
        }
    }
}