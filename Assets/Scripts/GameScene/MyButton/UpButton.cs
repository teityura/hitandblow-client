using UnityEngine;

namespace MyButton
{
    public class UpButton : MonoBehaviour
    {
        [SerializeField]
        private int numberIndex = -1;

        private StandardButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<StandardButton>();
        }

        private void Start()
        {
            standardButton.OnClick(() => Up());
        }

        private void Up()
        {
            int currentNumber = NumberManager.I.GetNumber(numberIndex);
            int nextNumber = (currentNumber == 9) ? 0 : currentNumber + 1;
            NumberManager.I.SetNumber(numberIndex, nextNumber);
        }
    }
}
