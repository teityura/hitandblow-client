using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using HitBlow.Manager;

public class ToResultTimerPanel : MonoBehaviour
{
    [SerializeField]
    private Text leftTimeLine2 = null;

    [SerializeField]
    private GameObject toResultTimerPanel = null;

    public IEnumerator ToResultScene()
    {
        toResultTimerPanel.SetActive(true);

        int waitSecond = 3;

        for (int i=0; i<waitSecond; i++)
        {
            leftTimeLine2.text = $"残り <color=#bb0000>{waitSecond - i}</color> 秒";
            yield return new WaitForSeconds(1);
        }

        GameManager.SetGamePhase(GameManager.GAME_PHASE.RESULT_START);
        SceneManager.LoadScene("ResultScene");
    }
}
