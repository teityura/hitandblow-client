using UnityEngine;
using UnityEngine.SceneManagement;
using HitBlow.Manager;
using UnityEngine.UI;

namespace HitBlow.MyButton
{
    public class RoomButton : MonoBehaviour
    {
        public void Initialize (int roomNumber)
        {
            this.roomNumber = roomNumber;
            this.roomName = "Room" + roomNumber.ToString();
        }

        [SerializeField]
        private Text roomText = null;
        private int roomNumber = 0;
        private string roomName = "Room0";

        private ActionButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<ActionButton>();
        }

        private void Start()
        {
            roomText.text = "ルーム: " + roomNumber.ToString();
            standardButton.OnClick(() => ToGameScene());
        }

        private void ToGameScene()
        {
            SceneManager.LoadScene("GameScene");
            GameManager.SetRoomName(roomName);
            GameManager.SetGamePhase(GameManager.GAME_PHASE.GAME_START);
            GameManager.ResetGameState();
            NumberManager.InitializeNumbers();
        }
    }
}
