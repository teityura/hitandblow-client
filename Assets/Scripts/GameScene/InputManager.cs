using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager
{
    [SerializeField]
    List<Button> buttons = new List<Button>();
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
