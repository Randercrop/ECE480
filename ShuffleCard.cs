using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Cards/NewShuffleCard", menuName = "ShuffleCard")]
public class ShuffleCard : ColoredCard {
    public override void OnPlay()
    {
       Pile.Shuffle();
    }
}
