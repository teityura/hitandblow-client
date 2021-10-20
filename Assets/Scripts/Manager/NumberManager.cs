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

            answerNumbers?.Clear();
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

        public static int GetHitCount()
        {
            int hitCount = 0;

            for (int i=0; i<inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == answerNumbers[i])
                {
                    hitCount += 1;
                }
            }

            return hitCount;
        }

        public static int GetBlowCount()
        {
            List<int> hitNumberList = new List<int>();
            List<int> blowNumberList = new List<int>();

            for (int i=0; i<inputNumbers.Count; i++)
            {
                // ヒット
                if (inputNumbers[i] == answerNumbers[i])
                {
                    hitNumberList.Add(inputNumbers[i]);
                }

                // ブロー
                if (answerNumbers.Contains(inputNumbers[i]))
                {
                    // 初回のブローだけリストに追加
                    if (!blowNumberList.Contains(inputNumbers[i]))
                    {
                        blowNumberList.Add(inputNumbers[i]);
                    }
                }
            }

            return blowNumberList.Count - hitNumberList.Count;
        }
    }
}
