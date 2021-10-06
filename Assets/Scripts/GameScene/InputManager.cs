using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MyButton;

public class InputManager
{
    [SerializeField]
    UpButton[] upButtons = new UpButton[4];
    DownButton[] downButtons = new DownButton[4];
    List<Button> submitButton = new List<Button>();
    public bool IsSubmit { get; private set; } = false;
    public bool IsInputPhase { get; private set; } = true;

    private void SetPhase(bool value)
    {
        this.IsInputPhase = value;
    }

    public void StartInput()
    {
        
    }
}
