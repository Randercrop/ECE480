using System;

public class Nope : Card
{
    public Nope()
    {
        name = "Nope";
        description = "Play this card at any time. Stop any action except for an IMPLODING DOGGO or a DEFUSE card.";
        ability = "nope";
    }
    public Nope(Deck thisDeck)
    {
        name = "Nope";
        description = "Play this card at any time. Stop any action except for an IMPLODING DOGGO or a DEFUSE card.";
        ability = "nope";
        this.thisDeck = thisDeck;
    }
}
