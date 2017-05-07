using System;

public class Board
{
    private List<Player> playerList = new List<Player>();
    private Deck drawDeck;
    private Deck discardDeck;
    private int turnCounter;
    private bool gameIsDone, won;
    private int numPlayers;

	public Board()
	{
        numPlayers = 5;

        playerList[0] = new Human(this, "Player1");
        playerList[1] = new CPU(this, "CPU1");
        playerList[2] = new CPU(this, "CPU2");
        playerList[3] = new CPU(this, "CPU3");
        playerList[4] = new CPU(this, "CPU4");
        playerList[5] = new CPU(this, "CPU5");

        drawDeck = new Deck(this, 10, 5, 0, 0, 0);
        discardDeck = new Deck(this, 0, 0, 0, 0, 0);

        gameIsDone = false;
        won = false;
    }
    public void init()
    {
        this.passOutHand();
        this.putBombs();
    }
    public void PlayGame()
    {
        while (!gameIsDone)
        {
            while (!playerList[turnCounter].endsTurn())
            {
                playerList[turnCounter].canPlayCard();
            }
            if (drawDeck.nextCardIsBomb())
            {
                if (playerList[turnCounter].hasDefuse)
                {
                    playerList[turnCounter].canPlayCard("Defuse");
                }
                else
                {
                    gameIsDone = true;
                    won = false;
                }
            }
            else
            {
                playerList[turnCounter].drawCard(drawDeck.getTopCards(1));
                turnCounter++;
            }
        }
    }
    public void endGame()
    {
        if (won == true)
        {
            Console.WriteLine("Congrats!");
        }
        else
        {
            Console.WriteLine("So sorry, better luck next time!");
        }
        Console.WriteLine("Play again?");
    }
    private void passOutHand()
    {
        for(int i = 0; i < playerList.Count; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                playerList[i].drawCard(drawDeck.getTopCards(1));
            }
        }
    }
    private void putBombs(int numBombs)
    {
        for(int i = 0; i < numBombs; i++)
        {
            drawDeck.putCard(new Bomb());
        }
        drawDeck.shuffle();
    }

}
