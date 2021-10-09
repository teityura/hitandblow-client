using UnityEngine;

namespace HitBlow.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static bool IsSubmitted { get; private set; } = false;

        public static void SetSubmit(bool value)
        {
            IsSubmitted = value;
        }
    }
}

