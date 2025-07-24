public static class Custom
{

  public static void Run() 
  {
    var set1 = new HashSet<int> { 1, 2, 3 };
    var set2 = new HashSet<int> { 2, 3, 4 };

    var intersection = CustomIntersection(set1, set2);
    var union = CustomUnion(set1, set2);

    Console.WriteLine("Intersection: " + string.Join(", ", intersection)); 
    Console.WriteLine("Union: " + string.Join(", ", union));      
  }

  public static HashSet<T> CustomIntersection<T>(HashSet<T> set1, HashSet<T> set2)
  {
    var newSet = new HashSet<T>();
    foreach (T item in set1)
    {
      if (set2.Contains(item))
      {
        newSet.Add(item);
      }
    }
    return newSet;
  }

  public static HashSet<T> CustomUnion<T>(HashSet<T> set1, HashSet<T> set2)
  {
    var newResult = new HashSet<T>();
    foreach (T item in set1)
    {
      newResult.Add(item);
    }

    foreach (T item in set2)
    {
      newResult.Add(item);
    }

    return newResult;
  }
}