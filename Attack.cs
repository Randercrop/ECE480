using System;

public class Attack : Card
{
    public Attack()
    {
        name = "Attack";
        description = "End your turn(s) without drawing and force the next player to take 2 turns in a row. The victim of this card takes a turn as normal. Then, when their first turn is over, it's their turn again. (If the victim of an ATTACK CARD plays an ATTACK CARD, their turns are immediately over, and the next player must take 2 turns.)";
        ability = "attack";
    }
    public Attack(Deck thisDeck)
    {
        name = "Attack";
        description = "End your turn(s) without drawing and force the next player to take 2 turns in a row. The victim of this card takes a turn as normal. Then, when their first turn is over, it's their turn again. (If the victim of an ATTACK CARD plays an ATTACK CARD, their turns are immediately over, and the next player must take 2 turns.)";
        ability = "attack";
        this.thisDeck = thisDeck;
    }
}
