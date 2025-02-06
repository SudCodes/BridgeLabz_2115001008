using System;

// Patient class
class Patient
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }

    public Patient(string name)
    {
        Name = name;
        Doctors = new List<Doctor>();
    }

    public void AddDoctor(Doctor doctor)
    {
        if (!Doctors.Contains(doctor))
        {
            Doctors.Add(doctor);
            doctor.AddPatient(this);
        }
    }

    public void ViewDoctors()
    {
        Console.WriteLine($"Patient: {Name} - Consulting Doctors:");
        foreach (var doctor in Doctors)
        {
            Console.WriteLine($"  Dr. {doctor.Name}, Specialization: {doctor.Specialization}");
        }
    }
}

// Doctor class
class Doctor
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    public List<Patient> Patients { get; set; }

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
        Patients = new List<Patient>();
    }

    public void AddPatient(Patient patient)
    {
        if (!Patients.Contains(patient))
        {
            Patients.Add(patient);
        }
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine($"Dr. {Name} is consulting {patient.Name}.");
    }

    public void ViewPatients()
    {
        Console.WriteLine($"Dr. {Name} - Patients:");
        foreach (var patient in Patients)
        {
            Console.WriteLine($"  {patient.Name}");
        }
    }
}

// Hospital class
class Hospital
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public Hospital(string name)
    {
        Name = name;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }
}

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital("City Hospital");

        Doctor doc1 = new Doctor("Viswas", "Cardiology");
        Doctor doc2 = new Doctor("Prakash", "Neurology");

        hospital.AddDoctor(doc1);
        hospital.AddDoctor(doc2);

        Patient patient1 = new Patient("Ramesh");
        Patient patient2 = new Patient("Jignesh");

        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        patient1.AddDoctor(doc1);
        patient1.AddDoctor(doc2);
        patient2.AddDoctor(doc1);

        doc1.Consult(patient1);
        doc2.Consult(patient1);
        doc1.Consult(patient2);

        patient1.ViewDoctors();
        patient2.ViewDoctors();

        doc1.ViewPatients();
        doc2.ViewPatients();
    }
}
