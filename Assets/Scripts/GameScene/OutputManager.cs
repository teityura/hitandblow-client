using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputManager
{
    public bool IsOutputPhase { get; private set; } = true;
    
    private void SetPhase(bool value)
    {
        this.IsOutputPhase = value;
    }

    public void StartOutput()
    {

    }
}
