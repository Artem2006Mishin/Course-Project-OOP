namespace Course_Project_OOP.Models;

public class Hospital
{
    public string Name { get; private set; }
    public int Capacity { get; private set; }

    private List<Patient> _patients;

    public IReadOnlyList<Patient> Patients => _patients.AsReadOnly();

    public Hospital(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
        _patients = new List<Patient>();
    }

    public bool AddPatient(Patient patient, out string error)
    {
        error = string.Empty;
        
        if (_patients.Count >= Capacity)
        {
            return false; // нет места
        }

        if (_patients.Any(p => p.Id == patient.Id))
        {
            error = "Пациент с таким ID уже существует";
            return false;
        }
        
        _patients.Add(patient);
        return true;
    }

    public bool RemovePatient(int patientId)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == patientId);
        if (patient == null)
            return false;

        _patients.Remove(patient);
        return true;
    }
}