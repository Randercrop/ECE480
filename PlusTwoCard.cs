using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Cards/PlusThreeCard", menuName = "PlusThreeCard")]
public class PlusTwoCard : ColoredCard {
    public override void OnPlay() {

        base.OnPlay();
        Pile.PullCard(3);
    }

    public override bool CanBePlayed()
    {
        return base.CanBePlayed();
    }
}
