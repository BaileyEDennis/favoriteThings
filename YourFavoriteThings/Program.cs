using System;
using YourFavoriteThings.FavoriteThings;
namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //books
            FavBook book1 = new FavBook("I, Robot", "Isaac Asimov", 256);
            book1.Bored();
            book1.HardRead();
            //animal
            FavAnimal animal1 = new FavAnimal("Goat", 150);
            animal1.Bite();
            animal1.CanPet();
            //vacation
            FavVacation vaca1 = new FavVacation("Denver", "Mountains", 10);
            vaca1.GetAway();
            vaca1.Relax();

        }
    }
}
