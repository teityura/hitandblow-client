using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace HitBlow.Manager
{
    public static class NumberManager
    {
        private static readonly List<int> inputNumbers = new List<int> {0, 0, 0, 0};
        private static readonly List<int> answerNumbers = SetAnswerNumbers();

        public static List<int> SetAnswerNumbers()
        {
            List<int> answerNumbers = new List<int>();

            for (int i=0; i<inputNumbers.Count; i++)
            {
                int randamNumber = Random.Range(0, 9);

                while (answerNumbers.Contains(randamNumber))
                {
                    randamNumber = Random.Range(0, 9);
                }

                answerNumbers.Add(randamNumber);
            }

            // DEBUG answerNumbers
            Debug.Log("answerNumbers: " + string.Join("", answerNumbers.Select(num => num.ToString())));

            return answerNumbers;
        }

        public static List<int> GetNumbers()
        {
            return inputNumbers;
        }

        public static int GetNumber(int index)
        {
            return inputNumbers[index];
        }

        public static void SetNumber(int index, int number)
        {
            inputNumbers[index] = number;
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
