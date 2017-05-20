using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Incomplete
[CreateAssetMenu(fileName = "Cards/NewChocolateBunCard", menuName = "ChocolateBunCard")]
public class BlockCard : ColoredCard {
    public override void OnPlay()
    {
        
        for (int i = 0; i < GameManager.NextPlayer.hand.Count; i++)
        {
            //CardView view = GameManager.NextPlayer.hand[i].GetComponent<CardView>();
            //GameManager.NextPlayer.hand.Remove(view);
            //GameManager.NextPlayer.hand[i].transform.SetParent(GameManager.NextPlayer.HandGameObject.transform);
            Destroy(GameManager.NextPlayer.hand[i]);
        }
        GameManager.NextPlayer.hand.Clear();
        //GameManager.ToggleNextPlayer(true);
        GameManager.EndTurn();
    }
}
