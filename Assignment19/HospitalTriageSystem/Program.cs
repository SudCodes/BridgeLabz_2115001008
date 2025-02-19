using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class HospitalTriage
{
    private SortedDictionary<int, Queue<Patient>> queue = new SortedDictionary<int, Queue<Patient>>();

    public void AddPatient(string name, int severity)
    {
        if (!queue.ContainsKey(-severity)) 
        {
            queue[-severity] = new Queue<Patient>();
        }
        queue[-severity].Enqueue(new Patient(name, severity));
    }

    public string TreatPatient()
    {
        if (queue.Count == 0) return "No patients left.";

        var highestSeverity = queue.Keys.Min(); 
        var patient = queue[highestSeverity].Dequeue();

        if (queue[highestSeverity].Count == 0)
        {
            queue.Remove(highestSeverity);
        }

        return patient.Name;
    }
}

class Program
{
    static void Main()
    {
        HospitalTriage triage = new HospitalTriage();

        triage.AddPatient("John", 3);
        triage.AddPatient("Alice", 5);
        triage.AddPatient("Bob", 2);

        Console.WriteLine("Order of treatment:");
        Console.WriteLine(triage.TreatPatient()); 
        Console.WriteLine(triage.TreatPatient()); 
        Console.WriteLine(triage.TreatPatient()); 
    }
}
