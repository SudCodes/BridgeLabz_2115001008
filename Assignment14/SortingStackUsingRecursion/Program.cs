using System;
class CustomStack
{
    private int[] arr;
    private int top;

    public CustomStack(int size)
    {
        arr = new int[size];
        top = -1;
    }

    public bool IsEmpty() => top == -1;

    public void Push(int item)
    {
        if (top == arr.Length - 1) throw new InvalidOperationException("Stack Overflow");
        arr[++top] = item;
    }

    public int Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack Underflow");
        return arr[top--];
    }

    public int Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return arr[top];
    }


    public void Print()
    {
        for (int i = top; i >= 0; i--) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
class Program
{
    static void SortStack(CustomStack stack)
    {
        if (!stack.IsEmpty())
        {
            int top = stack.Pop();
            SortStack(stack);
            InsertInSortedOrder(stack, top);
        }
    }

    static void InsertInSortedOrder(CustomStack stack, int element)
    {
        if (stack.IsEmpty() || stack.Peek() >= element)
        {
            stack.Push(element);
            return;
        }

        int temp = stack.Pop();
        InsertInSortedOrder(stack, element);
        stack.Push(temp);
    }

    public static void Main()
    {
        CustomStack stack = new CustomStack(10);
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(10);
        stack.Push(8);
        stack.Push(11);
        stack.Push(5);
        stack.Push(7);
        stack.Push(9);

        Console.WriteLine("Original Stack:");
        stack.Print();
      
        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        stack.Print();

    }
}
