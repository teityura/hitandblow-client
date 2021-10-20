using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace HitBlow.Manager
{
    public static class NumberManager
    {
        private static readonly List<int> inputNumbers = new List<int> {0, 0, 0, 0};

        private static List<int> answerNumbers = null;

        public static void InitializeNumbers()
        {            
            for(int i=0; i<inputNumbers.Count; i++)
            {
                SetInputNumber(i, 0);
            }

            answerNumbers.Clear();
            SetAnswerNumbers();
        }

        public static void SetInputNumber(int index, int number)
        {
            inputNumbers[index] = number;
        }

        private static void SetAnswerNumbers()
        {
            List<int> randomNumbers = new List<int>();

            for (int i=0; i<inputNumbers.Count; i++)
            {
                int randomNumber = Random.Range(0, 9);

                while (randomNumbers.Contains(randomNumber))
                {
                    randomNumber = Random.Range(0, 9);
                }

                randomNumbers.Add(randomNumber);
            }

            answerNumbers = randomNumbers;

            // DEBUG answerNumbers
            Debug.Log("answerNumbers: " + string.Join("", randomNumbers.Select(num => num.ToString())));
        }

        public static List<int> GetInputNumbers()
        {
            return inputNumbers;
        }

        public static int GetInputNumber(int index)
        {
            return inputNumbers[index];
        }

        public static int GetHitNumber()
        {
            int hitCount = 0;

            for (int i=0; i<inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == answerNumbers[i])
                {
                    hitCount += 1;
                }
            }

            // ヒットが4つあれば、リザルトへの遷移を準備開始
            if (hitCount == 4)
            {
                GameManager.SetGamePhase(GameManager.GAME_PHASE.GAME_END);
                GameManager.SetWinnerPlayer(GameManager.CurrentPlayerNumber);
            }

            return hitCount;
        }

        public static int GetBlowNumber()
        {
            int blowCount = 0;

            for (int i=0; i<inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == answerNumbers[i])
                {
                    // ヒットならカウントしない
                    continue;
                }
                else if (answerNumbers.Contains(inputNumbers[i]))
                {
                    blowCount += 1;
                }
            }

            return blowCount;

        }
    }
}
