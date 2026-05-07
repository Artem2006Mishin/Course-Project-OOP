namespace Course_Project_OOP.Models;

public class Patient
{
    public int Id { get; set; }
    public int HospitalId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Disease { get; set; }
    public string Department { get; set; }
    public string DiseaseSeverity { get; set; }
    public string IllnessDuration { get; set; }

    public Patient(
        int id,
        int hospitalId,
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        string disease,
        string department,
        string diseaseSeverity,
        string illnessDuration)
    {
        Id = id;
        HospitalId = hospitalId;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Disease = disease;
        Department = department;
        DiseaseSeverity = diseaseSeverity;
        IllnessDuration = illnessDuration;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Disease})";
    }
}
