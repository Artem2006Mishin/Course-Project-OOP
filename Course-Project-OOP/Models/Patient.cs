namespace Course_Project_OOP.Models;

public class Patient
{
    public int Id { get; set; } // важно для БД
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Diagnosis { get; set; }

    public Patient(int id, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Diagnosis = diagnosis;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Diagnosis})";
    }
}