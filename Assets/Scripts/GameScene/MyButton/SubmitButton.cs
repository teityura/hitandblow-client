// using UnityEngine;
// using UnityEngine.UI;

// public class SubmitButton : MonoBehaviour
// {
//     [SerializeField]
//     private Image targetImage = null;

//     private StandardButton standardButton = null;
//     private int currentNumber = 0;

//     private void Awake()
//     {
//         standardButton = GetComponent<StandardButton>();
//     }

//     private void Start()
//     {
//         standardButton.OnClick(() => Down());
//     }

//     private void Down()
//     {
//         currentNumber = (currentNumber == 0) ? 9 : currentNumber - 1;
//     }
// }

