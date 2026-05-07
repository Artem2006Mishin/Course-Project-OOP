namespace Course_Project_OOP.Models;

public class HospitalRegistry
{
    private readonly List<Hospital> _hospitals = new();

    public IReadOnlyList<Hospital> Hospitals => _hospitals.AsReadOnly();

    public bool AddHospital(Hospital hospital, out string error)
    {
        error = string.Empty;

        if (_hospitals.Any(h => h.Id == hospital.Id))
        {
            error = "Больница с таким ID уже существует";
            return false;
        }

        _hospitals.Add(hospital);
        return true;
    }

    public bool AddPatient(Patient patient, out string error)
    {
        error = string.Empty;

        var hospital = GetHospitalById(patient.HospitalId);
        if (hospital == null)
        {
            error = "Больница с таким ID не существует";
            return false;
        }

        if (_hospitals.SelectMany(h => h.Patients).Any(p => p.Id == patient.Id))
        {
            error = "Пациент с таким ID уже существует";
            return false;
        }

        return hospital.AddPatient(patient, out error);
    }

    public bool RemovePatient(int hospitalId, int patientId, out string error)
    {
        error = string.Empty;

        var hospital = GetHospitalById(hospitalId);
        if (hospital == null)
        {
            error = "Больница с таким ID не существует";
            return false;
        }

        if (!hospital.RemovePatient(patientId))
        {
            error = "Пациент с таким ID в этой больнице не найден";
            return false;
        }

        return true;
    }

    public Hospital? GetHospitalById(int hospitalId)
    {
        return _hospitals.FirstOrDefault(h => h.Id == hospitalId);
    }
}
