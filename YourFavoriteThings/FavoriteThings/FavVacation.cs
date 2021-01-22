using System;

namespace YourFavoriteThings.FavoriteThings
{
    public class FavVacation
    {
        public string Location { get; set; }
        public string Vista { get; set; }
        public bool Relaxing { get; set; } = true;
        public int Time { get; set; }

        public FavVacation(string location, string vista, int time)
        {
            Location = location;
            Vista = vista;
            Time = time;
        }

        public void Relax()
        {
            if (Relaxing)
            {
                Console.WriteLine($"{Location} is relaxing");
            }
            else
            {
                Console.WriteLine($"{Location} is not relaxing, but it's fun!");
            }
        }

        public void GetAway()
        {
            if (Time > 5)
            {
                Console.WriteLine("This is a vacation to get away from it all!");
            }
            else
            {
                Console.WriteLine("This is a short vacation!");
            }
        }

    }
}
