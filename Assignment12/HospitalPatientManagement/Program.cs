using System;
using System.Collections.Generic;

abstract class Patient
{
    public int PatientId { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }

    protected Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    public abstract double CalculateBill();

    public virtual void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}, Bill Amount: {CalculateBill():C}");
    }
}

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

class InPatient : Patient, IMedicalRecord
{
    private List<string> MedicalRecords = new List<string>();
    private int DaysAdmitted;
    private double DailyCharge;

    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge)
        : base(patientId, name, age)
    {
        DaysAdmitted = daysAdmitted;
        DailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }

    public void AddRecord(string record)
    {
        MedicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in MedicalRecords)
        {
            Console.WriteLine($"- {record}");
        }
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine($"Days Admitted: {DaysAdmitted}, Daily Charge: {DailyCharge:C}");
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private List<string> MedicalRecords = new List<string>();
    private double ConsultationFee;

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        ConsultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return ConsultationFee;
    }

    public void AddRecord(string record)
    {
        MedicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in MedicalRecords)
        {
            Console.WriteLine($"- {record}");
        }
    }

    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine($"Consultation Fee: {ConsultationFee:C}");
    }
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Rahul Sharma", 45, 5, 2000),
            new OutPatient(102, "Anjali Verma", 30, 500)
        };

        foreach (var patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine();
        }

        IMedicalRecord inpatientRecord = new InPatient(103, "Amit Kumar", 50, 7, 1800);
        inpatientRecord.AddRecord("Diabetes Treatment");
        inpatientRecord.AddRecord("Routine Checkup");
        inpatientRecord.ViewRecords();
    }
}
