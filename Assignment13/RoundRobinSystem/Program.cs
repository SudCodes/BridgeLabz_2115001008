using System;

class Process
{
    public int processId;
    public int burstTime;
    public int priority;
    public Process next;

    public Process(int processId, int burstTime, int priority)
    {
        this.processId = processId;
        this.burstTime = burstTime;
        this.priority = priority;
        this.next = null;
    }
}

class RoundRobinScheduler
{
    private Process head;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.head = null;
        this.timeQuantum = timeQuantum;
    }

    public void AddProcess(int processId, int burstTime, int priority)
    {
        Process newProcess = new Process(processId, burstTime, priority);
        if (head == null)
        {
            head = newProcess;
            head.next = head;
            return;
        }
        Process temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        temp.next = newProcess;
        newProcess.next = head;
    }

    public void RemoveProcess(int processId)
    {
        if (head == null) return;
        Process temp = head, prev = null;
        do
        {
            if (temp.processId == processId)
            {
                if (prev != null)
                    prev.next = temp.next;
                else
                {
                    Process last = head;
                    while (last.next != head)
                    {
                        last = last.next;
                    }
                    head = temp.next;
                    last.next = head;
                }
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
    }

    public void ExecuteProcesses()
    {
        if (head == null) return;
        Process temp = head;
        int totalWaitingTime = 0, totalTurnAroundTime = 0, count = 0;

        while (true)
        {
            bool allDone = true;
            Process current = temp;
            do
            {
                if (current.burstTime > 0)
                {
                    allDone = false;
                    int executeTime = Math.Min(timeQuantum, current.burstTime);
                    current.burstTime -= executeTime;
                    totalTurnAroundTime += executeTime;
                    Console.WriteLine($"Executing Process {current.processId} for {executeTime} units");
                }
                current = current.next;
            } while (current != temp);

            if (allDone) break;
        }
        Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / count}");
    }

    public void DisplayProcesses()
    {
        if (head == null) return;
        Process temp = head;
        do
        {
            Console.WriteLine($"Process ID: {temp.processId}, Burst Time: {temp.burstTime}, Priority: {temp.priority}");
            temp = temp.next;
        } while (temp != head);
    }
}

public class Program
{
    public static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4);
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        Console.WriteLine("Initial Process List:");
        scheduler.DisplayProcesses();

        Console.WriteLine("\nExecuting Processes:");
        scheduler.ExecuteProcesses();
    }
}
