
class Solution {

    static const int NO_PIVOT_INTEGER_FOUND = -1;

public:
    int pivotInteger(int n) {
        int sumAllValues = n * (n + 1) / 2;
        int squareRootOfSumAllValuesRoundedDownToNearestInteger = sqrt(sumAllValues);

        return (squareRootOfSumAllValuesRoundedDownToNearestInteger
                * squareRootOfSumAllValuesRoundedDownToNearestInteger)
                == sumAllValues
                ? squareRootOfSumAllValuesRoundedDownToNearestInteger
                : NO_PIVOT_INTEGER_FOUND;
    }
};
