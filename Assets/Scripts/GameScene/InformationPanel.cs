using UnityEngine;
using UnityEngine.UI;

public class InformationPanel : MonoBehaviour
{
    [SerializeField]
    private Text currentPlayer = null;

    [SerializeField]
    private Text turnCounter = null;


    public void SetCurrentPlayer(int number)
    {
        if (number % 2 == 1)
        {
            currentPlayer.text = $"プレイヤー: <color=#bb0000>{number}</color>";
        }
        else
        {
            currentPlayer.text = $"プレイヤー: <color=#0000bb>{number}</color>";
        }
    }

    public void SetTurnCounter(int number)
    {
        turnCounter.text = $"ターン: <color=#ff8c00>{number}</color>";
    }
}
