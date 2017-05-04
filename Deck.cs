using System;
using System.Collections.Generic;

public class Deck
{
    private int deckSize;
    private List<Card> someCards = new List<Card>();
    private Board thisBoard;
    
	public Deck()
	{
        someCards.Add(new Defuse(this));
	}

    public Deck(Board thisBoard, int deckSize, int numBomb, int numDefuse, int numShuffle, int numSkip)
    {
        for(int i = 0; i < numBomb; i++)
        {
            someCards.Add(new Bomb(this));
        }
        for(int i = 0; i < numDefuse; i++)
        {
            someCards.Add(new Defuse(this));
        }
        for (int i = 0; i < numShuffle; i++)
        {
            someCards.Add(new Shuffle(this));
        }
        for(int i = 0; i < numSkip; i++)
        {
            someCards.Add(new Skip(this));
        }
        for(int i = 0; i < deckSize - numBomb - numDefuse - numShuffle - numSkip; i++)
        {
            someCards.Add(new Card());
        }

        deckSize = someCards.Count;

        this.thisBoard = thisBoard;
    }

    public void ShuffleDeck()
    {
        Random rng = new Random();
        for(int i = someCards.Count -1; i > 0 ; i--)
        {
            int rndindex = rng.Next(someCards.Count);
            swapCards(ref someCards[i], ref someCards[rndindex]);
        }
        return true;
    }
    private void swapCards(ref Card a, ref Card b)
    {
        Card temp = a;
        a = b;
        b = temp;
    }
    public int DeckSize
    {
        get { return deckSize; }
    }
    public void playCard(Card cardToPlay)
    {
        cardToPlay.playCard();
    }
}
