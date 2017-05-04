using System;

public class Skip : Card
{
	public Skip()
	{
        name = "Skip";
        description = "Skip the rest of this turn.";
        ability = "skip";
    }
    public Skip (Deck thisDeck)
    {
        name = "Skip";
        description = "Skip the rest of this turn.";
        ability = "skip";
        this.thisDeck = thisDeck;
    }
}
