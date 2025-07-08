public class PriorityQueue
{
  private List<PriorityItem> _queue = new();

  /// <summary>
  /// Add a new value to the queue with an associated priority.  The
  /// node is always added to the back of the queue regardless of 
  /// the priority.
  /// </summary>
  /// <param name="value">The value</param>
  /// <param name="priority">The priority</param>
  public void Enqueue(string value, int priority)
  {
    var newNode = new PriorityItem(value, priority);
    _queue.Add(newNode);
  }

  public string Dequeue()
  {
    if (_queue.Count == 0) // Verify the queue is not empty
    {
      throw new InvalidOperationException("The queue is empty.");
    }

    // Find the index of the item with the highest priority to remove

    // Fixed loop condition. The for loop does not check the last element because it stops at index < _queue.Count - 1. 
    // To make sure it does not miss the correct item if the last element has the highest priority.
    // I corrected it, I changed it to index < _queue.Count; and then used the .RemoveAt to remove.
    var highPriorityIndex = 0;
    for (int index = 1; index < _queue.Count; index++)
    {
      if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
        highPriorityIndex = index;
    }

    // Remove and return the item with the highest priority
    var value = _queue[highPriorityIndex].Value;
    _queue.RemoveAt(highPriorityIndex);
    return value;
  }

  public override string ToString()
  {
    return $"[{string.Join(", ", _queue)}]";
  }
}

internal class PriorityItem
{
  internal string Value { get; set; }
  internal int Priority { get; set; }

  internal PriorityItem(string value, int priority)
  {
    Value = value;
    Priority = priority;
  }

  public override string ToString()
  {
    return $"{Value} (Pri:{Priority})";
  }
}