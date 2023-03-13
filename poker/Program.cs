internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("Hello, World!");
        Cards c = new Cards();
        Player p = new Player();
        c.Deal(r, p);
        Console.WriteLine("Your hand:");
        foreach(int i in p.hand)
        {
            Console.WriteLine(c.toString(i));
        }
        Console.WriteLine("The flop:");
        foreach(int i in c.Flop(r))
        {
            Console.WriteLine(c.toString(i));
        }
        Console.WriteLine("(C)heck, (R)aise, or (B)et?");
        Console.ReadLine();
        Console.WriteLine("The turn:");
        foreach(int i in c.Turn(r))
        {
            Console.WriteLine(c.toString(i));
        }
        Console.WriteLine("Your hand:");
        foreach (int i in p.hand)
        {
            Console.WriteLine(c.toString(i));
        }
        Console.WriteLine("(C)heck, (R)aise, or (B)et?");
        Console.ReadLine();
        Console.WriteLine("The river:");
        foreach (int i in c.River(r))
        {
            Console.WriteLine(c.toString(i));
        }
        Console.WriteLine("Your hand:");
        foreach (int i in p.hand)
        {
            Console.WriteLine(c.toString(i));
        }

    }
}