using UnityEngine;
using System.Collections;
using System;

[CreateAssetMenu(fileName = "Cards/NewReverseCard", menuName = "ReverseCard")]
public class ReverseCard : ColoredCard
{
    public override bool CanBePlayed()
    {
        return (base.CanBePlayed());
    }
    public override void OnPlay()
    {
        base.OnPlay();

        GameManager.CurrentPlayer.HandGameObject.SetActive(false);
        GameManager.ToggleReversePlayer();
        GameManager.EndTurn();
    }
}

/*
 * PUT IN GAMEMANAGER.CS
 
    public static void ToggleReversePlayer(bool nextPlayer = true)
    {
        if (nextPlayer)
        {
            PlayerIndex--;
            PlayerIndex--;
        }
        else
            playerIndex--;

        BeginTurn();
    }

*/