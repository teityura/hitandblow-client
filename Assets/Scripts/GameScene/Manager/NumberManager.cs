namespace HitBlow.Manager
{
    public static class NumberManager
    {
        private static int[] inputNumbers = new int[4] {0, 0, 0, 0};

        public static int[] GetNumbers()
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
    }
}
