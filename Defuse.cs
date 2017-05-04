using System;

public class Defuse : Card
{
	public Defuse()
	{
        name = "Defuse";
        description = "If you drew an EXPLODING KITTEN, you can play this card instead of dying.";
        ability = "lifesaver";
    }
    public Defuse(Deck thisDeck)
    {
        name = "Defuse";
        description = "If you drew an EXPLODING KITTEN, you can play this card instead of dying.";
        ability = "lifesaver";
        this.thisDeck = thisDeck;
    }
    public override void playCard()
    {
        Console.WriteLine("Playing a defuse card. Bomb should cancel and shuffle back into deck.");
        return null;
    }
}
