using System;

public class Bomb : Card
{
	public Bomb()
	{
        name = "Exploding Kitten";
        description = "explodes on the player who draws this card.";
        ability = "bomb";
    }
    public Bomb(Deck thisDeck)
    {
        name = "Exploding Kitten";
        description = "explodes on the player who draws this card.";
        ability = "bomb";
        this.thisDeck = thisDeck;
    }
    
}
