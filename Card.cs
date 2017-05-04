using System;

public class Card
{
    private string name;
    private string description;
    private string ability;
    private Deck thisDeck;
    private Board thisBoard;

	public Card()
	{
        name = "blank card";
        description = "white card used for testing";
        ability = "none";
        
	}
    public Card(Deck thisDeck)
    {

        if (cardName == "nope")
        {
            name = "Nope!";
            description = "Play this card at any time. Stop any action except for an EXPLODING KITTEN or a DEFUSE card.";
            ability = "nope";
            height = 7.0;
            width = 5.0;
        }
        else if (cardName == "attack")
        {
            name = "Attack";
            description = "End your turn(s) without drawing and force the next player to take 2 turns in a row. The victim of this card takes a turn as normal. Then, when their first turn is over, it's their turn again. (If the victim of an ATTACK CARD plays an ATTACK CARD, their turns are immediately over, and the next player must take 2 turns.)";
            ability = "atk";
            height = 7.0;
            width = 5.0;
        }

        name = "blank card";
        description = "white card used for testing";
        ability = "none";
        this.thisDeck = thisDeck;

    }
    public string getAbility
    {
        get { return ability; }
    }
    public Deck thisDeck
        //mutator for class reference thisDeck
    {
        get { return thisDeck; }
        set { this.thisDeck = value; }
    }


    public virtual void playCard()
        //virtual function for playing a card
        //this will be overwritten in the individual card classes
    {
        Console.WriteLine("Playing a blank card. Returning null");
        return null;
    }
    
}
