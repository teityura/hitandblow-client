using UnityEngine;
using UnityEngine.UI;
using HitBlow.Manager;

namespace HitBlow.Manager
{
    public class ResultSceneDrawManager : MonoBehaviour
    {
        [SerializeField]
        private Text resultText = null;

        private void Start()
        {
            resultText.text = $"結果\n\nプレイヤー{GameManager.WinnerPlayerNumber}の勝ち！";
        }
    }
}
