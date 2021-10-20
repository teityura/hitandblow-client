using UnityEngine;
using UnityEngine.UI;

namespace HitBlow.Manager
{
    public class ResultSceneDrawManager : MonoBehaviour
    {
        [SerializeField]
        private Text resultText = null;

        private void Start()
        {
            resultText.text = "結果:\n";

            if (GameManager.IsGameOver)
            {
                resultText.text += $"ゲームオーバーです！\n";
            }
            else
            {
                resultText.text += $"<color=#0000bb>プレイヤー{GameManager.WinnerPlayerNumber}</color> の勝ち！\n";
            }
            
            resultText.text += $"答えは <color=#bb0000bb>{NumberManager.AnswerNumber}</color>でした。";
        }
    }
}
