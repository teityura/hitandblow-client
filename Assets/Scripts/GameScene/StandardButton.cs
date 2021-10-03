using System;
using UnityEngine;
using UnityEngine.UI;

public class StandardButton : Button
{
    private Action callback = null;

    protected override void Awake()
    {
        base.Awake();
        this.onClick.AddListener(InvokeAction);
    }

    private void InvokeAction()
    {
        callback?.Invoke();
    }

    public void SetAction(Action callback)
    {
        this.callback = callback;
    }
}
