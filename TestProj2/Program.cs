namespace TestProj2;

class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Console.WriteLine("Player 1, please enter your name");
        p1.setUsername(Console.ReadLine());
        Console.WriteLine("Player 2, please enter your name");
        p2.setUsername(Console.ReadLine());
        Console.WriteLine($"Hello {p1.username}");
        Console.WriteLine($"Hello {p2.username}");
        Console.WriteLine($"{p1.username} , {p2.username}\n{p1.score} , {p2.score}");

        
    }
    public class Player
    {
        public string username {get; set;}
        public void setUsername(string username)
        {
            this.username = username;
        }
        public int score {get; set;} = 0;

    }
}
