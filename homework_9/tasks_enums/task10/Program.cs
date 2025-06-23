namespace _homework_9_task_10
{
    public enum Genre
    {
        Action,
        Drama,
        Comedy,
        Horror,
        SciFi
    }

    public struct Movie
    {
        public string Title;
        public Genre Genre;
        public double Rating;

        public Movie(string title, Genre genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Inception", Genre.SciFi, 8.8),
                new Movie("Titanic", Genre.Drama, 7.8),
                new Movie("The Room", Genre.Drama, 3.7),
                new Movie("The Conjuring", Genre.Horror, 7.5),
                new Movie("Die Hard", Genre.Action, 8.2),
                new Movie("The Hangover", Genre.Comedy, 7.7),
                new Movie("Sharknado", Genre.Horror, 3.3),
                new Movie("Interstellar", Genre.SciFi, 8.6)
            };

            // Create genre-based lists
            List<Movie> action = new List<Movie>();
            List<Movie> drama = new List<Movie>();
            List<Movie> comedy = new List<Movie>();
            List<Movie> horror = new List<Movie>();
            List<Movie> scifi = new List<Movie>();

            // Filter and group
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Rating > 7.5)
                {
                    switch (movies[i].Genre)
                    {
                        case Genre.Action:
                            action.Add(movies[i]);
                            break;
                        case Genre.Drama:
                            drama.Add(movies[i]);
                            break;
                        case Genre.Comedy:
                            comedy.Add(movies[i]);
                            break;
                        case Genre.Horror:
                            horror.Add(movies[i]);
                            break;
                        case Genre.SciFi:
                            scifi.Add(movies[i]);
                            break;
                    }
                }
            }

            // Print grouped results
            PrintGenre("Action", action);
            PrintGenre("Drama", drama);
            PrintGenre("Comedy", comedy);
            PrintGenre("Horror", horror);
            PrintGenre("SciFi", scifi);
        }

        static void PrintGenre(string name, List<Movie> list)
        {
            Console.WriteLine($"\n{name}:");
            if (list.Count == 0)
                Console.WriteLine("  (None)");
            else
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine($"- {list[i].Title} ({list[i].Rating})");
        }
    }
}
