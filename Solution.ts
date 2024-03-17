
function pivotInteger(n: number): number {

    const NO_PIVOT_INTEGER_FOOUND = -1;
    let sumAllValues = n * (n + 1) / 2;
    let squareRootOfSumAllValuesRoundedDownToNearestInteger = Math.floor(Math.sqrt(sumAllValues));

    return (squareRootOfSumAllValuesRoundedDownToNearestInteger
           * squareRootOfSumAllValuesRoundedDownToNearestInteger)
           === sumAllValues
           ? squareRootOfSumAllValuesRoundedDownToNearestInteger
           : NO_PIVOT_INTEGER_FOOUND;
};
