using System;

public class Defuse : Card
{
	public Defuse()
	{
        name = "Defuse";
        description = "If you drew an IMPLODING DOGGO, you can play this card instead of losing.";
        ability = "lifesaver";
    }
    public Defuse(Deck thisDeck)
    {
        name = "Defuse";
        description = "If you drew an IMPLODING DOGGO, you can play this card instead of losing.";
        ability = "lifesaver";
        this.thisDeck = thisDeck;
    }
    public override void playCard()
    {
        Console.WriteLine("Playing a defuse card. IMPLODING DOGGO will cancel and shuffle back into deck.");
        return null;
    }
}
