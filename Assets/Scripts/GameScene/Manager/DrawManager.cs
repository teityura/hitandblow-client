using UnityEngine;
using UnityEngine.UI;

namespace HitBlow.Manager
{
    public class DrawManager : MonoBehaviour
    {
        [SerializeField]
        private Image[] inputNumberImages = null;

        [SerializeField]
        GameObject answeredNumberPanelPrefab = null;

        [SerializeField]
        Transform answeredNumberPanelPrefabParent = null;

        void Update()
        {
            GameManager.GAME_PHASE phase = GameManager.GamePhase;

            switch(phase)
            {
                case GameManager.GAME_PHASE.INPUT:
                    RefreshInputPanels();
                    // NOTE: Submitボタンで、OUTPUTフェーズに切り替えている
                    break;
                case GameManager.GAME_PHASE.OUTPUT:
                    RefreshOutputPanels();
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.INPUT);
                    break;
                default:
                    return;
            }
        }

        private void RefreshInputPanels()
        {
            for (int i=0; i<inputNumberImages.Length; i++)
            {
                int currentNumber = NumberManager.GetNumber(i);
                inputNumberImages[i].sprite = SpriteManager.GetNumberSprite(currentNumber);
            }
        }

        private void RefreshOutputPanels()
        {
            GameObject instantiatedObject = Instantiate(answeredNumberPanelPrefab, answeredNumberPanelPrefabParent);
            AnsweredNumberPanel answeredNumberPanel = instantiatedObject.GetComponent<AnsweredNumberPanel>();

            Sprite hitNumberSprite = SpriteManager.GetNumberSprite(0);
            Sprite blowNumberSprite = SpriteManager.GetNumberSprite(0);

            int[] inputNumbers = NumberManager.GetNumbers();
            Sprite[] answeredNumberSprites = new Sprite[inputNumbers.Length];

            for (int i=0; i<inputNumbers.Length; i++)
            {
                answeredNumberSprites[i] = SpriteManager.GetNumberSprite(inputNumbers[i]);
            }

            answeredNumberPanel.SetAnsweredNumberImages(answeredNumberSprites);
            answeredNumberPanel.SetHitNumberImage(hitNumberSprite);
            answeredNumberPanel.SetBlowNumberImage(blowNumberSprite);
        }
    }
}
