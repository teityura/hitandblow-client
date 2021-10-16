using UnityEngine;
using HitBlow.Manager;

namespace HitBlow.MyButton
{
    public class SubmitButton : MonoBehaviour
    {
        private ActionButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<ActionButton>();
        }

        private void Start()
        {
            standardButton.OnClick(() => Submit());
        }

        private void Submit()
        {
            GameManager.SetGamePhase(GameManager.GAME_PHASE.OUTPUT);
        }
    }
}
