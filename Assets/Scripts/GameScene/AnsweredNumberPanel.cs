using UnityEngine;
using UnityEngine.UI;

public class AnsweredNumberPanel : MonoBehaviour
{
    [SerializeField]
    private Image[] answeredNumberImages = null;

    [SerializeField]
    private Image hitNumberImage = null;

    [SerializeField]
    private Image blowNumberImage = null;

    public void SetAnsweredNumberImages(Sprite[] sprites)
    {
        for (int i=0; i<sprites.Length; i++)
        {
            answeredNumberImages[i].sprite = sprites[i];
        }
    }

    public void SetHitNumberImage(Sprite sprite)
    {
        hitNumberImage.sprite = sprite;
    }

    public void SetBlowNumberImage(Sprite sprite)
    {
        blowNumberImage.sprite = sprite;
    }
}
