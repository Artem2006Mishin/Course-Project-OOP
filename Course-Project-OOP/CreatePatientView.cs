namespace Course_Project_OOP;
using Models;

public partial class CreatePatientView : UserControl
{
    private readonly Hospital _hospital;

    public event EventHandler? PatientAdded;

    public CreatePatientView(Hospital hospital)
    {
        InitializeComponent();
        _hospital = hospital;
    }
    
    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtId.Text, out int id))
        {
            MessageBox.Show("ID должен быть числом");
            return;
        }
        
        var patient = new Patient(
            id,
            txtFirstName.Text,
            txtLastName.Text,
            dtpBirth.Value,
            txtDiagnosis.Text
        );
        
        if (!_hospital.AddPatient(patient, out string error))
        {
            MessageBox.Show(error);
            return;
        }

        MessageBox.Show("Пациент успешно добавлен");
        ClearForm();
        PatientAdded?.Invoke(this, EventArgs.Empty);
    }
    
    private void ClearForm()
    {
        txtId.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtDiagnosis.Clear();
        dtpBirth.Value = DateTime.Now;
    }
}
