﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    static Player[] players = new Player[2];
    public static int playerIndex = 0;
    static GameObject continueUI;
    public static GameObject victoryUI;
    public Color red, yellow, blue, green;
    static GameManager instance;
    static bool ifAlreadyPulled;

    public static int PlayerIndex {
        get {return playerIndex;}
        set {playerIndex = (value + players.Length) % players.Length;
        }
    }

    public static Player CurrentPlayer {
        get {
            return players[PlayerIndex];
        }
    }
    public static Player NextPlayer
    {
        get
        {
            //if (Direction)
            //{
            //    return players[playerIndex + 1];
            //}
            //else
            //{
            //    return players[playerIndex - 1];
            //}
            
            return players[((PlayerIndex + 1) % players.Length)];
        }
    }

    public void Start() {
        instance = this;     
        for(int i = 0; i < players.Length; i++) {
            players[i] = new Player();
        }

        GameObject.FindGameObjectWithTag("CardHolder").GetComponent<Button>().onClick.AddListener(onPileClick);

        //Start game
        StartGame();
    }


    public void Update() {
        if(Input.GetKeyDown(KeyCode.P)) {
            onPileClick();
        }
        if(Input.GetKeyDown(KeyCode.Return) && continueUI) {
            OnContinueUIClick();
        }
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    public void onPileClick() {
        if (continueUI) return;
        
        CardController controller = Pile.instance.pile[0];

        if(!ifAlreadyPulled) {
            if(controller.CanBePlayed()) {
                ifAlreadyPulled = true;
                foreach(CardView view in GameManager.CurrentPlayer.hand) {
                    view.IsDraggable = false;
                }
                Pile.PullCard();
            } else {
                EndTurn();
                Pile.PullCard();
            }
        }
    }

    public static void StartGame() {
        //First player
        PlayerIndex = 0;

        //Set first turn for all players true
        foreach(Player p in players) {
            p.isFirstTurn = true;
        }

        BeginTurn();
    }

    public static void BeginTurn() {
        ifAlreadyPulled = false;

        foreach(CardView view in GameManager.CurrentPlayer.hand) {
            view.IsDraggable = true;
        }

        //Set current hand as scrollable
        Pile.instance.GetComponent<ScrollRect>().content = CurrentPlayer.HandGameObject.GetComponent<RectTransform>();
        //Set current player in textbar
        GameObject.FindGameObjectWithTag("PlayerTextBar").GetComponentInChildren<Text>().text = "PLAYER " + (PlayerIndex + 1) + "'S TURN";
        //if this is the first turn for you as a player take 7 cards
        if(CurrentPlayer.isFirstTurn) {
            Pile.PullCard(5);
            CurrentPlayer.isFirstTurn = false;
        }

        CurrentPlayer.HandGameObject.SetActive(true);
    }

    public static GameObject createUI(string text, string btnText)
    {
        GameObject createdUI = Resources.Load<GameObject>("Press Continue");
        createdUI = Instantiate<GameObject>(createdUI);
        createdUI.transform.SetParent(Pile.instance.transform);
        createdUI.transform.SetAsLastSibling();
        createdUI.transform.localPosition = new Vector3(0, 300, 0);

        /* de hierarchy opbouw
        GAMEOBJECT
        >   TEXT "componentInChildren t.o.v Gameobject"
        >   BUTTON
            >   TEXT "getChild(1) van GAMEOBJECT is Button, componentInChildren t.o.v Button"
        */

        createdUI.GetComponentInChildren<Text>().text = text;
        createdUI.transform.GetChild(1).GetComponentInChildren<Text>().text = btnText;

        return createdUI;
    }

   public static void CheckVictoryCondition() {
        
            Debug.Log("victory");
        //    victoryUI = createUI("player " + (PlayerIndex + 1) + " wins", "restart");
         //   victoryUI.GetComponentInChildren<Button>().onClick.AddListener(StartNewGame);
        
    }

    public static void EndTurn() {
        if(CurrentCard.IsFirstCard)
            return;

        CurrentPlayer.HandGameObject.SetActive(false);
        continueUI = createUI("END OF PLAYER " + (PlayerIndex + 1) + "'S TURN", "continue");
        continueUI.GetComponentInChildren<Button>().onClick.AddListener(OnContinueUIClick);
    }

    public static void OnContinueUIClick() {
        Destroy(continueUI);
        ToggleNextPlayer();
    }

    public static void ToggleNextPlayer(bool nextPlayer = true) {
        if(nextPlayer)
            PlayerIndex++;
        else
            playerIndex--;
        BeginTurn();
    }

    public static void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }

}