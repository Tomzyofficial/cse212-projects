public static class Arrays
{

  public static void Run()
  {
    // MultiplesOf
    var multiples = MultiplesOf(3, 5);
    Console.WriteLine("double[]", string.Join(", ", multiples));

    // RotateListRight
    var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    RotateListRight(data, 3);
    Console.WriteLine("Rotated by 3: <list>{" + string.Join(", ", data) + "}");
  }


  /// <summary>
  /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
  /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
  /// integer greater than 0.
  /// </summary>
  /// <returns>array of doubles that are the multiples of the supplied number</returns>
  public static double[] MultiplesOf(double number, int length)
  {
    // TODO Problem 1 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.


    /// To solve the problem of implementing the MultiplesOf function, we will follow these steps:
    /// 1. With our method containing two parameters "number" (the base number) and "length" (the number of multiples to generate).
    /// 2. Create an array of double with the size of 'length'.
    /// 3. Use a loop to iterate from 0 to length - 1.
    /// 4. For each index 'i', calculate the value as 'number * (i + 1)'.
    /// 5. Assign the calculated value to the corresponding index in the array.
    /// 6. Finally, return the array containing the multiples.
    /// <param name="number">this is the number to produce multiples of</param>
    /// <param name="length">this is the number of multiples to produce</param>

    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
      result[i] = number * (i + 1);
    }
    return result;
  }


  /// <summary>
  /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
  /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
  /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
  ///
  /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
  /// </summary>
  public static void RotateListRight(List<int> data, int amount)
  {
    // TODO Problem 2 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.  


    /// To solve the problem of rotating a list to the right by a specified amount, we will follow these steps:
    /// 1. With our method containing two parameters "data" (the list of integers) and "amount" (the number of positions to rotate).
    /// 2. Calculate the effective rotation amount by taking the modulus of the amount with the data.Count to handle cases where the amount is greater than the list size.
    /// 3. If the effective rotation amount is zero, return immediately as no rotation is
    ///    needed. Else
    /// 4. Identify the last 'effectiveAmount' elements of the list.
    /// 5. Identify the remaining elements of the list that will be shifted to the left.
    ///  6. Concatenate the last elements with the remaining elements to form a new list.
    ///  7. Clear the original list and add the elements from the new list back to it.
    /// <param name="data">the list of integers to rotate</param>
    /// <param name="amount">the number of elements to rotate</param>

    int effectiveAmount = amount % data.Count;
    if (effectiveAmount == 0)
    {
      return;
    }

    var lastElements = data.Skip(data.Count - effectiveAmount);
    var remainingElements = data.Take(data.Count - effectiveAmount);
    var newList = lastElements.Concat(remainingElements).ToList();
    data.Clear();
    data.AddRange(newList);

  }
}
