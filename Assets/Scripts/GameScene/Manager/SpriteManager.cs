using UnityEngine;

namespace HitBlow.Manager
{
    public class SpriteManager : MonoBehaviour
    {
        private static SpriteManager instance;
        public static SpriteManager I
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpriteManager();
                }
                return instance;
            }
        }

        [SerializeField]
        private Sprite[] numberSpritesSerialized = null;

        private static Sprite[] numberSprites = null;

        private void Awake()
        {
            numberSprites = numberSpritesSerialized;
        }

        public static Sprite GetNumberSprite(int number)
        {
            return numberSprites[number];
        }
    }
}
