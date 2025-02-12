using System;

class TaskNode
{
    public int taskId;
    public string taskName;
    public int priority;
    public DateTime dueDate;
    public TaskNode next;

    public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
    {
        this.taskId = taskId;
        this.taskName = taskName;
        this.priority = priority;
        this.dueDate = dueDate;
        this.next = null;
    }
}

class TaskScheduler
{
    private TaskNode head;
    private TaskNode currentTask;

    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.next = head;
            currentTask = head;
            return;
        }
        TaskNode temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        newTask.next = head;
        temp.next = newTask;
        head = newTask;
    }

    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.next = head;
            currentTask = head;
            return;
        }
        TaskNode temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        temp.next = newTask;
        newTask.next = head;
    }

    public void RemoveTask(int taskId)
    {
        if (head == null) return;
        if (head.taskId == taskId && head.next == head)
        {
            head = null;
            currentTask = null;
            return;
        }
        TaskNode temp = head, prev = null;
        do
        {
            if (temp.taskId == taskId)
            {
                if (prev != null)
                {
                    prev.next = temp.next;
                }
                else
                {
                    TaskNode last = head;
                    while (last.next != head)
                    {
                        last = last.next;
                    }
                    head = temp.next;
                    last.next = head;
                }
                if (currentTask == temp)
                    currentTask = head;
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
    }

    public void ViewCurrentTask()
    {
        if (currentTask != null)
        {
            Console.WriteLine($"Task ID: {currentTask.taskId}, Name: {currentTask.taskName}, Priority: {currentTask.priority}, Due Date: {currentTask.dueDate}");
        }
    }

    public void MoveToNextTask()
    {
        if (currentTask != null)
        {
            currentTask = currentTask.next;
        }
    }

    public void DisplayTasks()
    {
        if (head == null) return;
        TaskNode temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.taskId}, Name: {temp.taskName}, Priority: {temp.priority}, Due Date: {temp.dueDate}");
            temp = temp.next;
        } while (temp != head);
    }

    public TaskNode SearchByPriority(int priority)
    {
        if (head == null) return null;
        TaskNode temp = head;
        do
        {
            if (temp.priority == priority)
                return temp;
            temp = temp.next;
        } while (temp != head);
        return null;
    }
}

public class TaskManager
{
    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTaskAtBeginning(1, "Task 1", 2, DateTime.Now.AddDays(3));
        scheduler.AddTaskAtEnd(2, "Task 2", 1, DateTime.Now.AddDays(5));
        scheduler.AddTaskAtEnd(3, "Task 3", 3, DateTime.Now.AddDays(1));

        Console.WriteLine("Task List:");
        scheduler.DisplayTasks();

        Console.WriteLine("\nCurrent Task:");
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nMoving to Next Task:");
        scheduler.MoveToNextTask();
        scheduler.ViewCurrentTask();

        Console.WriteLine("\nSearching Task with Priority 1:");
        TaskNode foundTask = scheduler.SearchByPriority(1);
        if (foundTask != null)
        {
            Console.WriteLine($"Found Task - ID: {foundTask.taskId}, Name: {foundTask.taskName}");
        }

        Console.WriteLine("\nRemoving Task 2:");
        scheduler.RemoveTask(2);
        scheduler.DisplayTasks();
    }
}
