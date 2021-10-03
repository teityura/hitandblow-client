using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] numberSprites = new Sprite[10];

    public Sprite GetNumberSprite(int index)
    {
        return numberSprites[index];
    }
}
