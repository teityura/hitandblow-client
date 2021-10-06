using UnityEngine;

public class NumberManager
{
    private static NumberManager instance;
    public static NumberManager I
    {
        get
        {
            if (instance == null)
            {
                instance = new NumberManager();
            }
            return instance;
        }
    }

    private static int[] inputNumbers = new int[4] {0, 0, 0, 0};

    public int GetNumber(int index)
    {
        return inputNumbers[index];
    }

    public void SetNumber(int index, int number)
    {
        NumberManager.inputNumbers[index] = number;
        // int i0 = NumberManager.inputNumbers[0];
        // int i1 = NumberManager.inputNumbers[1];
        // int i2 = NumberManager.inputNumbers[2];
        // int i3 = NumberManager.inputNumbers[3];
        // Debug.Log($"inputNumbers: {i0}, {i1}, {i2}, {i3}");
    }
}
