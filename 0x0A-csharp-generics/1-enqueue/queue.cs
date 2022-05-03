using System;

/// <summary>
/// Custom generic class Queue
/// </summary>
/// <typeparam name="T">Could be any type</typeparam>

class Queue<T>
{


    public Node head { get; set; }
    public Node tail { get; set; }
    private int count;
    /// <summary>
    /// Insert node in the Queue 
    /// </summary>
    /// <param name="value"> the value of the  node </param>
    public void Enqueue(T value)
    {
        Node n = new Node(value);
        if (count == 0)
        {
            head = n;
            tail = n;
            head.next = null;
        }
        else
        {
            tail.next = n;
        }
        this.count += 1;
    }
    /// <summary>
    /// Checks the type of this generic class.
    /// </summary>
    /// <returns>Returns the type of the generic class.</returns>
    public String CheckType()
    {
        return typeof(T).ToString();
    }
    /// <summary>
    /// Get the number of nodes in the queue 
    /// </summary>
    /// <returns>the number of node in queue</returns>
    public int Count()
    {
        return this.count;
    }/// <summary>
     /// The Queue of Node 
     /// </summary>
    public class Node
    {
        private T value { get; set; }
        public Node next { get; set; }
        public Node(T value)
        {
            this.value = value;
        }

    }
}