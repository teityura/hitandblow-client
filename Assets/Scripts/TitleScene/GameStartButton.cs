using UnityEngine;
using UnityEngine.SceneManagement;
using HitBlow.Manager;

namespace HitBlow.MyButton
{
    public class GameStartButton : MonoBehaviour
    {
        private ActionButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<ActionButton>();
        }

        private void Start()
        {
            standardButton.OnClick(() =>ToLobbyScene());
        }

        private void ToLobbyScene()
        {
            SceneManager.LoadScene("LobbyScene");
            GameManager.SetGamePhase(GameManager.GAME_PHASE.LOBBY_START);
        }
    }
}
