using System;

namespace YourFavoriteThings.FavoriteThings
{
    public class FavBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public bool IsBoring { get; set; } = false;

        //constructor
        public FavBook(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Console.WriteLine($"Favorite book is {Title} by {Author}");
        }

        //Methods
        public void Bored()
        {
            if (IsBoring)
            {
                Console.WriteLine("This book is boring, I need a new favorite book!");
                IsBoring = true;
            }
            else
            {
                Console.WriteLine($"{Title} is my favorite book");
            }
        }

        public void HardRead()
        {
            if (Length > 400)
            {
                Console.WriteLine("Strap in, this is a hard read!");
            }
            else
            {
                Console.WriteLine("This is a quick read, no sweat!");
            }
        }
    }
}
