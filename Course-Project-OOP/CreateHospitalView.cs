namespace Course_Project_OOP;
using Models;

public partial class CreateHospitalView : UserControl
{
    private readonly HospitalRegistry _registry;

    public event EventHandler? HospitalAdded;

    public CreateHospitalView(HospitalRegistry registry)
    {
        InitializeComponent();
        _registry = registry;
        cmbHospitalType.SelectedIndex = 0;
        txtOccupiedBeds.Text = "0";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtId.Text, out int id))
        {
            MessageBox.Show("ID больницы должен быть числом");
            return;
        }

        if (!int.TryParse(txtCapacity.Text, out int capacity))
        {
            MessageBox.Show("Вместимость должна быть числом");
            return;
        }

        if (capacity < 0)
        {
            MessageBox.Show("Вместимость не может быть отрицательной");
            return;
        }

        var hospitalType = cmbHospitalType.SelectedIndex == 0 ? HospitalType.Adult : HospitalType.Children;
        var hospital = new Hospital(id, txtName.Text, capacity, hospitalType);

        if (!_registry.AddHospital(hospital, out string error))
        {
            MessageBox.Show(error);
            return;
        }

        MessageBox.Show("Больница успешно добавлена");
        ClearForm();
        HospitalAdded?.Invoke(this, EventArgs.Empty);
    }

    private void ClearForm()
    {
        txtId.Clear();
        txtName.Clear();
        txtCapacity.Clear();
        txtOccupiedBeds.Text = "0";
        cmbHospitalType.SelectedIndex = 0;
    }
}
