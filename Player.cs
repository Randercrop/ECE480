using System;

public class Player
{
    private string nickname;
    private Deck cardsInHand;
    private int numOfCards = cardsInHand;
    private bool isPlaying;
    private Board mainBoard;
    
	public Player()
	{
        nickname = "Your Nickname";
        cardsInHand = new Deck();
        numOfCards = cardsInHand.DeckSize;
        isPlaying = false;
	}
    public Player(Board thisBoard, string nname)
    {
        nickname = nname;
        this.mainBoard = thisBoard;
    }
    public void playCard()
    {

    }
}
