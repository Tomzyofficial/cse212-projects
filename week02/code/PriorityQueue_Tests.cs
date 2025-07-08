using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
  [TestMethod]
  // Scenario: Enqueue items with different priorities. 
  // each run returns the item with the highest priority first.
  // Expected Result: Dequeue will return the item with the highest priority first.
  // Defect(s) Found: Original dequeue missed last item due to wrong `for` loop condition. Didn't remove dequeued item from the queue.
  public void TestPriorityQueue_1()
  {
    /*  var priorityQueue = new PriorityQueue();
     Assert.Fail("Implement the test case and then remove this."); */

    var pq = new PriorityQueue();
    pq.Enqueue("Low", 2);
    pq.Enqueue("High", 5);
    pq.Enqueue("Medium", 3);

    string result = pq.Dequeue();
    Assert.AreEqual("High", result, "The highest priority item should be dequeued first.");
  }

  // Add more test cases as needed below.

  [TestMethod]
  // Scenario: Create a queue with multiple items with the same priority.
  // Expected Result: Using the FIFO data structure, the item enqueued first will be dequeued first.
  // Defect(s) Found: FIFO structure is correctly implemented, because the loop gets the first item with the highest priority.
  public void TestPriorityQueue_2()
  {
    /*  var priorityQueue = new PriorityQueue();
     Assert.Fail("Implement the test case and then remove this."); */

    var pq = new PriorityQueue();
    pq.Enqueue("First", 20);
    pq.Enqueue("Second", 20);
    pq.Enqueue("Third", 20);

    string result = pq.Dequeue();
    string result2 = pq.Dequeue();
    string result3 = pq.Dequeue();

    Assert.AreEqual("First", result, "The first item should be dequeued first when priorities are equal.");
    Assert.AreEqual("Second", result2, "The second item should be dequeued next when priorities are equal.");
    Assert.AreEqual("Third", result3, "The third item should be dequeued last when priorities are equal.");
  }


  [TestMethod]
  // Scenario: Dequeue from an empty queue.
  // Expected Result: It will throw InvalidOperationException if the queue is empty.
  // Defect(s) Found: None found, the code correctly throws exception error.
  public void TestPriorityQueueEmptyQueue_3()
  {
    var pq = new PriorityQueue();
    Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue(), "Dequeue should throw an exception when the queue is empty.");
  }
}