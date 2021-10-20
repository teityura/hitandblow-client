using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace HitBlow.Manager
{
    public class GameSceneDrawManager : MonoBehaviour
    {
        [SerializeField]
        private Image[] inputNumberImages = null;

        [SerializeField]
        GameObject answeredNumberPanelPrefab = null;

        [SerializeField]
        Transform answeredNumberPanelPrefabParent = null;

        [SerializeField]
        private InformationPanel informationPanel = null;

        [SerializeField]
        private ToResultTimerPanel toResultTimerPanel = null;

        void Update()
        {
            GameManager.GAME_PHASE phase = GameManager.GamePhase;

            switch(phase)
            {
                case GameManager.GAME_PHASE.GAME_START:
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.GAME_INPUT);
                    break;
                case GameManager.GAME_PHASE.GAME_INPUT:
                    RefreshInputPanels();
                    break;
                // NOTE: Submitボタンで、OUTPUTフェーズに切り替えている
                case GameManager.GAME_PHASE.GAME_OUTPUT:
                    RefreshOutputPanels();
                    RefreshInformationPanel();
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.GAME_INPUT);
                    break;
                // NOTE: GetHitNumberでhitが4個あれば、GAME_ENDフェーズに切り替えている
                case GameManager.GAME_PHASE.GAME_END:
                    StartCoroutine(toResultTimerPanel.ToResultScene());
                    GameManager.SetGamePhase(GameManager.GAME_PHASE.RESULT_TIMER);
                    break;
                case GameManager.GAME_PHASE.RESULT_TIMER:
                    break;
                default:
                    return;
            }
        }

        private void RefreshInputPanels()
        {
            for (int i=0; i<inputNumberImages.Length; i++)
            {
                int currentNumber = NumberManager.GetInputNumber(i);
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
            List<int> inputNumbers = NumberManager.GetInputNumbers();
            Sprite[] answeredNumberSprites = new Sprite[inputNumbers.Count];

            for (int i=0; i<inputNumbers.Count; i++)
            {
                answeredNumberSprites[i] = SpriteManager.GetNumberSprite(inputNumbers[i]);
            }

            panel.SetAnsweredNumberImages(answeredNumberSprites);
        }

        private void RefreshHitBlowNumber(AnsweredNumberPanel panel)
        {
            int hit = NumberManager.GetHitCount();
            int blow = NumberManager.GetBlowCount();

            Sprite hitNumberSprite = SpriteManager.GetHitBlowNumberSprite(hit);
            Sprite blowNumberSprite = SpriteManager.GetHitBlowNumberSprite(blow);

            panel.SetHitNumberImage(hitNumberSprite);
            panel.SetBlowNumberImage(blowNumberSprite);
        }

        private void RefreshInformationPanel()
        {
            int currentTurn = GameManager.CurrentTurn;
            int currentPlayer = (int)GameManager.CurrentPlayerNumber;

            informationPanel.SetTurnCounter(currentTurn);
            informationPanel.SetCurrentPlayer(currentPlayer);
        }
    }
}
