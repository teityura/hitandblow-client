using UnityEngine;
using UnityEngine.SceneManagement;

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
            standardButton.OnClick(() => SceneManager.LoadScene("LobbyScene"));
        }
    }
}
