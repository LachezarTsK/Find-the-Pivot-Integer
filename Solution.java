
public class Solution {

    private static final int NO_PIVOT_INTEGER_FOOUND = -1;

    public int pivotInteger(int n) {

        int sumAllValues = n * (n + 1) / 2;
        int squareRootOfSumAllValuesRoundedDownToNearestInteger = (int) Math.sqrt(sumAllValues);

        return (squareRootOfSumAllValuesRoundedDownToNearestInteger
                * squareRootOfSumAllValuesRoundedDownToNearestInteger)
                == sumAllValues
                ? squareRootOfSumAllValuesRoundedDownToNearestInteger
                : NO_PIVOT_INTEGER_FOOUND;
    }
}