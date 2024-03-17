
using System;

public class Solution
{
    private static readonly int NO_PIVOT_INTEGER_FOUND = -1;

    public int PivotInteger(int n)
    {

        int sumAllValues = n * (n + 1) / 2;
        int squareRootOfSumAllValuesRoundedDownToNearestInteger = (int)Math.Sqrt(sumAllValues);

        return (squareRootOfSumAllValuesRoundedDownToNearestInteger
                * squareRootOfSumAllValuesRoundedDownToNearestInteger)
                == sumAllValues
                ? squareRootOfSumAllValuesRoundedDownToNearestInteger
                : NO_PIVOT_INTEGER_FOUND;
    }
}
