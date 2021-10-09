using UnityEngine;

namespace HitBlow.Manager
{
    public class SpriteManager : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] numberSpritesSerialized = null;

        [SerializeField]
        private Sprite[] hitNumberSpritesSerialized = null;

        private static Sprite[] numberSprites = null;
        private static Sprite[] hitNumberSprites = null;

        private void Awake()
        {
            numberSprites = numberSpritesSerialized;
            hitNumberSprites = hitNumberSpritesSerialized;
        }

        public static Sprite GetNumberSprite(int number)
        {
            return numberSprites[number];
        }
    }
}
