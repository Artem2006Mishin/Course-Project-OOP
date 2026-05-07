namespace Course_Project_OOP.Models;

public enum HospitalType
{
    Adult,
    Children
}

public class Hospital
{
    private readonly List<Patient> _patients;

    public int Id { get; }
    public string Name { get; }
    public int Capacity { get; }
    public HospitalType Type { get; }
    public int OccupiedBeds => _patients.Count;

    public IReadOnlyList<Patient> Patients => _patients.AsReadOnly();

    public Hospital(int id, string name, int capacity, HospitalType type)
    {
        Id = id;
        Name = name;
        Capacity = capacity;
        Type = type;
        _patients = new List<Patient>();
    }

    public bool AddPatient(Patient patient, out string error)
    {
        error = string.Empty;

        if (OccupiedBeds >= Capacity)
        {
            error = "В больнице нет свободных мест";
            return false;
        }

        if (_patients.Any(p => p.Id == patient.Id))
        {
            error = "Пациент с таким ID уже существует в этой больнице";
            return false;
        }

        _patients.Add(patient);
        return true;
    }

    public bool RemovePatient(int patientId)
    {
        var patient = _patients.FirstOrDefault(p => p.Id == patientId);
        if (patient == null)
        {
            return false;
        }

        _patients.Remove(patient);
        return true;
    }

    public string GetDisplayType()
    {
        return Type == HospitalType.Adult ? "Взрослая" : "Детская";
    }
}
