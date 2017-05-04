using System;

public class Shuffle : Card
{
	public Shuffle()
	{
        name = "Shuffle";
        description = "shuffles the deck";
        ability = "shuffle";
    }
    public Shuffle(Deck thisDeck)
    {
        name = "Shuffle";
        description = "shuffles the deck";
        ability = "shuffle";
        this.thisDeck = thisDeck;

    }

}
