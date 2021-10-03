using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{
    [SerializeField]
    private SpriteManager spriteManager = null;

    [SerializeField]
    private Image targetImage = null;

    private StandardButton standardButton = null;
    private int currentNumber = 0;

    private void Awake()
    {
        standardButton = GetComponent<StandardButton>();
    }

    private void Start()
    {
        standardButton.SetAction(() => Up());
    }

    private void Up()
    {
        currentNumber = (currentNumber == 9) ? 0 : currentNumber + 1;
        targetImage.sprite = spriteManager.GetNumberSprite(currentNumber);
    }
}

