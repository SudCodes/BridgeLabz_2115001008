using System;
class QueueUsingStack<T>
{
    public Stack<T> stack1; //for enqueue
    public Stack<T> stack2; //for dequeue

    public QueueUsingStack()
    {
        stack1 = new Stack<T>();
        stack2 = new Stack<T>();
    }

    public bool isEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }

    public void enqueue (T item)
    {
        stack1.Push(item);
    }

    public T dequeue ()
    {
        if(isEmpty())
        {
            throw new InvalidOperationException("Queue is Empty!!");
        }
        if(stack2.Count == 0)
        {
            while(stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Pop();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        QueueUsingStack<int> queue = new QueueUsingStack<int>();

        queue.enqueue(1);
        queue.enqueue(2);
        queue.enqueue(3);

        Console.WriteLine(queue.dequeue());
        Console.WriteLine(queue.dequeue());
        Console.WriteLine(queue.dequeue());
        Console.WriteLine(queue.dequeue());
    }
}