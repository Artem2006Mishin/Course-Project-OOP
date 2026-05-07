namespace Course_Project_OOP;
using Models;

public partial class CreatePatientView : UserControl
{
    private readonly HospitalRegistry _registry;

    public event EventHandler? PatientAdded;

    public CreatePatientView(HospitalRegistry registry)
    {
        InitializeComponent();
        _registry = registry;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtId.Text, out int id))
        {
            MessageBox.Show("ID пациента должен быть числом");
            return;
        }

        if (!int.TryParse(txtHospitalId.Text, out int hospitalId))
        {
            MessageBox.Show("ID больницы должен быть числом");
            return;
        }

        var patient = new Patient(
            id,
            hospitalId,
            txtFirstName.Text,
            txtLastName.Text,
            dtpBirth.Value,
            txtDisease.Text,
            txtDepartment.Text,
            txtDiseaseSeverity.Text,
            txtIllnessDuration.Text
        );

        if (!_registry.AddPatient(patient, out string error))
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
        txtHospitalId.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtDisease.Clear();
        txtDepartment.Clear();
        txtDiseaseSeverity.Clear();
        txtIllnessDuration.Clear();
        dtpBirth.Value = DateTime.Now;
    }
}
