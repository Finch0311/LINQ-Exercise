namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<string> videoGames = new List<string>() { "Rainbow 6 Siege", "DarkSouls", "Castlevania"}    ;
            videoGames.Add("Minecraft");
            videoGames.Add("Legends of Dragoon");
            videoGames.Add("Suikoden");
            videoGames.Add("Ark");
            videoGames.Add("Final Fantasy X");

            var orderedGames = videoGames.OrderBy(name => name.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
