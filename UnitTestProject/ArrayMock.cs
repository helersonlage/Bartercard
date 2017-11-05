using System;

public class ArrayMock
{
    static int arrLength = 0;
    public int[] MockArray;

    public ArrayMock(int arrLength_)
    {
        arrLength = arrLength_;
        MockArray = new int[arrLength];
        MockArray = mockArray();
    }

    private int[] mockArray()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 50000);

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = random.Next(0, 10000);
        }

        return arr;
    }

}