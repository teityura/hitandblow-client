using UnityEngine;

namespace MyButton
{
    public class DownButton : MonoBehaviour
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
            standardButton.OnClick(() => Down());
        }

        private void Down()
        {
            int currentNumber = NumberManager.I.GetNumber(numberIndex);
            int nextNumber = (currentNumber == 0) ? 9 : currentNumber - 1;
            NumberManager.I.SetNumber(numberIndex, nextNumber);
        }
    }
}
