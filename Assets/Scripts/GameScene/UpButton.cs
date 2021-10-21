using UnityEngine;
using HitBlow.Manager;

namespace HitBlow.MyButton
{
    public class UpButton : MonoBehaviour
    {
        [SerializeField]
        private int numberIndex = -1;

        private ActionButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<ActionButton>();
        }

        private void Start()
        {
            standardButton.OnClick(() => Up());
        }

        private void Up()
        {
            int currentNumber = NumberManager.GetInputNumber(numberIndex);
            int nextNumber = (currentNumber == 9) ? 0 : currentNumber + 1;
            NumberManager.SetInputNumber(numberIndex, nextNumber);
        }
    }
}
