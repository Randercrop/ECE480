using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Cards/BunCard", menuName = "BunCard")]
public class BunCard : ColoredCard
{
    public override void OnPlay()
    {
        Debug.Log("victory");
        GameManager.victoryUI = GameManager.createUI("player " + (GameManager.PlayerIndex + 1) + " wins", "restart");
        GameManager.victoryUI.GetComponentInChildren<Button>().onClick.AddListener(GameManager.StartNewGame);

    }
}
