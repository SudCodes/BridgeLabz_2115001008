using System;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState current;
    private int historySize;
    private int count;

    public TextEditor(int historySize = 10)
    {
        this.historySize = historySize;
        count = 0;
        current = null;
    }

    public void AddState(string content)
    {
        TextState newState = new TextState(content);
        if (current != null)
        {
            current.Next = newState;
            newState.Prev = current;
        }
        current = newState;
        count++;

        // Limit history size
        if (count > historySize)
        {
            TextState temp = current;
            while (temp.Prev != null && count > historySize)
            {
                temp = temp.Prev;
                count--;
            }
            temp.Prev = null;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current Text: " + current.Content);
        }
        else
        {
            Console.WriteLine("No text available.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        editor.AddState("Hello, World");
        editor.AddState("Hello, World!");

        Console.WriteLine("Initial States:");
        editor.DisplayCurrentState();

        Console.WriteLine("\nUndo:");
        editor.Undo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nRedo:");
        editor.Redo();
        editor.DisplayCurrentState();
    }
}