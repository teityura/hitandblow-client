using UnityEngine;

namespace HitBlow.Manager
{
    public class SpriteManager : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] numberSpritesSerialized = null;

        [SerializeField]
        private Sprite[] hitBlowNumberSpritesSerialized = null;

        private static Sprite[] numberSprites = null;
        private static Sprite[] hitBlowNumberSprites = null;

        private void Awake()
        {
            numberSprites = numberSpritesSerialized;
            hitBlowNumberSprites = hitBlowNumberSpritesSerialized;
        }

        public static Sprite GetNumberSprite(int number)
        {
            return numberSprites[number];
        }

        public static Sprite GetHitBlowNumberSprite(int number)
        {
            return hitBlowNumberSprites[number];
        }
    }
}
