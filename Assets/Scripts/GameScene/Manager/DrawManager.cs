using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

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

        [SerializeField]
        private InformationPanel informationPanel = null;

        void Update()
        {
            GameManager.GAME_PHASE phase = GameManager.GamePhase;

            switch(phase)
            {
                // TODO: SetAnswerNumbers() を他のクラスでやらせる
                case GameManager.GAME_PHASE.START:
                    NumberManager.SetAnswerNumbers();
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.INPUT);
                    break;
                case GameManager.GAME_PHASE.INPUT:
                    RefreshInputPanels();
                    // NOTE: Submitボタンで、OUTPUTフェーズに切り替えている
                    break;
                case GameManager.GAME_PHASE.OUTPUT:
                    RefreshOutputPanels();
                    RefreshInformationPanel();
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
            // AnsweredNumberPanelを生成
            GameObject instantiatedObject = Instantiate(answeredNumberPanelPrefab, answeredNumberPanelPrefabParent);
            AnsweredNumberPanel answeredNumberPanel = instantiatedObject.GetComponent<AnsweredNumberPanel>();

            // Inputで入力した4ケタを描画
            RefreshAnsweredNumber(answeredNumberPanel);

            // Hit, Blow数を描画
            RefreshHitBlowNumber(answeredNumberPanel);
        }

        private void RefreshAnsweredNumber(AnsweredNumberPanel panel)
        {
            List<int> inputNumbers = NumberManager.GetNumbers();
            Sprite[] answeredNumberSprites = new Sprite[inputNumbers.Count];

            for (int i=0; i<inputNumbers.Count; i++)
            {
                answeredNumberSprites[i] = SpriteManager.GetNumberSprite(inputNumbers[i]);
            }

            panel.SetAnsweredNumberImages(answeredNumberSprites);
        }

        private void RefreshHitBlowNumber(AnsweredNumberPanel panel)
        {
            int hit = NumberManager.GetHitNumber();
            int blow = NumberManager.GetBlowNumber();

            Sprite hitNumberSprite = SpriteManager.GetHitBlowNumberSprite(hit);
            Sprite blowNumberSprite = SpriteManager.GetHitBlowNumberSprite(blow);

            panel.SetHitNumberImage(hitNumberSprite);
            panel.SetBlowNumberImage(blowNumberSprite);
        }

        private void RefreshInformationPanel()
        {
            int currentTurn = GameManager.CurrentTurn;
            int currentPlayer = GameManager.CurrentPlayer;

            informationPanel.SetTurnCounter(currentTurn);
            informationPanel.SetCurrentPlayer(currentPlayer);
        }
    }
}
