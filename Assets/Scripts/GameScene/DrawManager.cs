using UnityEngine;
using UnityEngine.UI;

public class DrawManager : MonoBehaviour
{
    [SerializeField]
    private SpriteManager spriteManager = null;

    [SerializeField]
    private Image[] inputNumberImages = new Image[4];

    void Update()
    {
        RefreshInputPanels();
    }

    private void RefreshInputPanels()
    {
        for (int i=0; i<inputNumberImages.Length; i++)
        {
            int currentNumber = NumberManager.I.GetNumber(i);
            inputNumberImages[i].sprite = spriteManager.GetNumberSprite(currentNumber);
        }
    }
}
