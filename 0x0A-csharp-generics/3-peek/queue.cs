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
    /// Remove a node from the Queue
    /// </summary>
    /// <returns>the default value of the parametre type or the value of node removed</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else
        {
            T tmp = head.value;
            head = head.next;
            count -= 1;
            return (tmp);
        }
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        else
        {
            return (head.value);
        }
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
        public T value { get; set; }
        public Node next { get; set; }
        public Node(T value)
        {
            this.value = value;
        }

    }
}