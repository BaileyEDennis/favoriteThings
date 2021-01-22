using System;
namespace YourFavoriteThings.FavoriteThings
{
    public class FavAnimal
    {
        public string Species { get; set; }
        public string Type { get; set; }
        public bool DoesBite { get; set; } = false;
        public int Weight { get; set; }

        public FavAnimal(string species, int weight)
        {
            Species = species;
            Weight = weight;
        }

        public void Bite()
        {
            if (DoesBite)
            {
                Console.WriteLine($"Careful, {Species} will bite you!");
            }
            else
            {
                Console.WriteLine($"Don't worry! {Species} does not bite!");
            }
        }

        public void CanPet()
        {
            if (Weight > 200)
            {
                Console.WriteLine($"{Species} is {Weight}, too heavy to pet!");
            }
            else
            {
                Console.WriteLine($"{Species} is pretty light, can pet!");
            }
        }
    }
}
