using UnityEngine;
using HitBlow.Manager;

namespace HitBlow.MyButton
{
    public class SendRequestButton : MonoBehaviour
    {
        private ActionButton standardButton = null;

        private void Awake()
        {
            standardButton = GetComponent<ActionButton>();
        }

        private void Start()
        {
            // pathを指定してリクエストを投げる
            standardButton.OnClick(() => HttpManager.SendRequest(""));

            // レスポンスを受け取って、何か処理をする
            HttpManager.OnComplete(responce => Debug.Log(responce));
        }
    }
}
