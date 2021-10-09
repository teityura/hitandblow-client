using System;
using UnityEngine.UI;

namespace MyButton
{
    public class ActionButton : Button
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

        public void OnClick(Action callback)
        {
            this.callback = callback;
        }
    }
}