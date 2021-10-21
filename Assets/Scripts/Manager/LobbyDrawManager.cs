using UnityEngine;
using HitBlow.MyButton;

namespace HitBlow.Manager
{
    public class LobbyDrawManager : MonoBehaviour
    {
        [SerializeField]
        private int MAX_ROOM_NUMBER = 8;

        [SerializeField]
        private GameObject roomPanelPrefab = null;

        [SerializeField]
        private Transform roomPanelPrefabParent = null;

        void Update()
        {
            GameManager.GAME_PHASE phase = GameManager.GamePhase;

            switch(phase)
            {
                case GameManager.GAME_PHASE.LOBBY_START:
                    RefreshRoomPanels();
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.LOBBY_INPUT);
                    // NOTE: RoomButtonボタンで、GAME_STARTフェーズに切り替えている
                    break;
                default:
                    return;
            }
        }

        private void RefreshRoomPanels()
        {
            for (int i=0; i<MAX_ROOM_NUMBER; i++)
            {
                // AnsweredNumberPanelを生成
                GameObject instantiatedObject = Instantiate(roomPanelPrefab, roomPanelPrefabParent);
                RoomButton roomButton = instantiatedObject.GetComponentInChildren<RoomButton>();
                roomButton.Initialize(i+1);
            }
        }
    }
}
