using System;

public class Shuffle : Card
{
	public Shuffle()
	{
        name = "Shuffle";
        description = "Shuffles all cards in the deck.";
        ability = "shuffle";
    }
    public Shuffle(Deck thisDeck)
    {
        name = "Shuffle";
        description = "Shuffles all cards in the deck.";
        ability = "shuffle";
        this.thisDeck = thisDeck;
    }
}
