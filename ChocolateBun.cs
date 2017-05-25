using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Incomplete
[CreateAssetMenu(fileName = "Cards/NewChocolateBunCard", menuName = "ChocolateBunCard")]
public class ChocolateBunCard : ColoredCard {
    public override void OnPlay()
    {
        
        for (int i = 0; i < GameManager.NextPlayer.hand.Count; i++)
        {
            Destroy(GameManager.NextPlayer.hand[i].CardFace);
            Destroy(GameManager.NextPlayer.hand[i].gameObject);
            Destroy(GameManager.NextPlayer.hand[i]);
        }
        GameManager.EndTurn();
    }
}
