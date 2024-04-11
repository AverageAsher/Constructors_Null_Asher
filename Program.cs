namespace Constructors_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and initialize it with values
            Game favoriteGame = new Game("The Legend of Zelda: Breath of the Wild", "Action-Adventure");

            // Print the title and genre of the initialized Game object
            Console.WriteLine("Title: " + favoriteGame.Title);
            Console.WriteLine("Genre: " + favoriteGame.Genre);
            Console.WriteLine();

            // Create another Game object without initializing it
            Game newGame = new Game();

            // Print the title and genre of the uninitialized Game object
            Console.WriteLine("Title: " + newGame.Title);
            Console.WriteLine("Genre: " + newGame.Genre);
        }
    }
}