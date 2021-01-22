using System;

namespace YourFavoriteThings.FavoriteThings
{
    public class FavCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public int Price { get; set; }

        public FavCar(string make, string model, int topSpeed, int price)
        {
            Make = make;
            Model = model;
            TopSpeed = topSpeed;
            Price = price;
        }

        public void Vroom()
        {
            if (TopSpeed > 160)
            {
                Console.WriteLine($"{Model} is a fast car!");
            }
            else
            {
                Console.WriteLine($"{Model} is not fast, but it sure is fun!");
            }
        }

        public void Expensive()
        {
            if (Price > 80000)
            {
                Console.WriteLine($"{Model} is an expensive car!");
            }
            else
            {
                Console.WriteLine($"{Model} is not expensive, nice find!");
            }
        }
    }
}
