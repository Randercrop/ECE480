using System;

public class Skip : Card
{
	public Skip()
	{
        name = "Skip";
        description = "End this turn without drawing a card from the deck.";
        ability = "skip";
    }
    public Skip (Deck thisDeck)
    {
        name = "Skip";
        description = "End this turn without drawing a card from the deck.";
        ability = "skip";
        this.thisDeck = thisDeck;
    }
}
