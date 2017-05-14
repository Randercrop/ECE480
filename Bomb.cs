using System;

public class Bomb : Card
{
	public Bomb()
	{
        name = "Imploding Doggo";
        description = "implodes the player who draws this card.";
        ability = "bomb";
    }
    public Bomb(Deck thisDeck)
    {
        name = "Imploding Doggo";
        description = "implodes the player who draws this card.";
        ability = "bomb";
        this.thisDeck = thisDeck;
    }
    
}
