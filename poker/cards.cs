using System;

public class Cards
{
    public List<int> deck, table, burned;
	public Cards()
	{
		deck = new List<int>(new int[52]);
        table = new List<int>();
        burned = new List<int>();
	}
	public void Deal(Random r, Player player)
	{

		for (int i = 0; i < 2; i++)
        {
        player.hand.Add(Draw(r));
        }
    }

    private int Draw(Random r)
    {
        int card = r.Next(52);
        while (deck[card] != 0)
        {
            card = r.Next(52);
        }
        deck[card]++;
        return card;
    }

    public String toString(int card)
    {
        String[] suits = new String[] { "Spades", "Clubs", "Hearts", "Diamonds" };
        String[] names = new String[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        String suit = suits[card / 13];
        String name = names[card % 13];
        return name + " of " + suit;
    }

    public List<int> Flop(Random r)
    {
        burned.Add(Draw(r));
        for(int i = 0; i < 3; i++)
        {
            table.Add(Draw(r));
        }
        return table;
    }

    public List<int> Turn(Random r)
    {
        burned.Add(Draw(r));
        table.Add(Draw(r));
        return table;
    }
    public List<int> River(Random r)
    {
        burned.Add(Draw(r));
        table.Add(Draw(r));
        return table;
    }
}
