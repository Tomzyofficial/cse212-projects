/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
  // change from List to Queue 
  private readonly Queue<Person> _queue = new();

  public int Length => _queue.Count;

  /// <summary>
  /// Add a person to the queue
  /// </summary>
  /// <param name="person">The person to add</param>
  public void Enqueue(Person person)
  {
    _queue.Enqueue(person);
  }

  public Person Dequeue()
  {
    return _queue.Dequeue();
  }

  public bool IsEmpty()
  {
    return _queue.Count == 0;
  }

  public override string ToString()
  {
    return $"[{string.Join(", ", _queue)}]";
  }
}