using UnityEngine;
using UnityEngine.UI;

public class InputNumberPanelDraw : MonoBehaviour
{
    [SerializeField]
    private SpriteManager spriteManager = null;

    [SerializeField]
    private Image[] inputNumberImages = new Image[4];

    void Update()
    {
        // Debug.Log(numberManager.GetNumber(0));
        // Debug.Log(numberManager.GetNumber(1));
        // Debug.Log(numberManager.GetNumber(2));
        // Debug.Log(numberManager.GetNumber(3));

        for (int i=0; i<inputNumberImages.Length; i++)
        {
            int currentNumber = NumberManager.I.GetNumber(i);
            inputNumberImages[i].sprite = spriteManager.GetNumberSprite(currentNumber);
        }
    }
}
