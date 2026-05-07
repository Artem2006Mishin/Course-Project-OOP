namespace Course_Project_OOP;
using Models;

public partial class MainView : UserControl
{
    private readonly HospitalRegistry _registry;

    public MainView(HospitalRegistry registry)
    {
        InitializeComponent();
        _registry = registry;
        RefreshHospitals();
    }

    public void RefreshHospitals()
    {
        RenderHospitals();
    }

    private void RenderHospitals()
    {
        flowHospitals.Controls.Clear();
        lblTitle.Text = _registry.Hospitals.Count == 0
            ? "Больницы пока не созданы"
            : $"Всего больниц: {_registry.Hospitals.Count}";

        foreach (var hospital in _registry.Hospitals)
        {
            flowHospitals.Controls.Add(CreateHospitalControl(hospital));
        }
    }

    private Control CreateHospitalControl(Hospital hospital)
    {
        var container = new Panel();
        container.Width = Math.Max(flowHospitals.ClientSize.Width - 30, 700);
        container.Height = 230 + Math.Max(hospital.Patients.Count, 1) * 28;
        container.BorderStyle = BorderStyle.FixedSingle;
        container.BackColor = SystemColors.ControlLightLight;

        var titleLabel = new Label();
        titleLabel.Text = $"Больница ID: {hospital.Id} | {hospital.Name}";
        titleLabel.Top = 8;
        titleLabel.Left = 8;
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        container.Controls.Add(titleLabel);

        int startY = 35;
        AddRow(container, "Тип:", hospital.GetDisplayType(), startY);
        AddRow(container, "Вместимость:", hospital.Capacity.ToString(), startY + 22);
        AddRow(container, "Занято мест:", hospital.OccupiedBeds.ToString(), startY + 44);

        var patientsLabel = new Label();
        patientsLabel.Text = "Пациенты:";
        patientsLabel.Left = 10;
        patientsLabel.Top = startY + 78;
        patientsLabel.AutoSize = true;
        patientsLabel.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        container.Controls.Add(patientsLabel);

        var grid = CreatePatientsGrid(hospital);
        grid.Left = 10;
        grid.Top = startY + 102;
        grid.Width = container.Width - 20;
        grid.Height = container.Height - grid.Top - 10;
        container.Controls.Add(grid);

        return container;
    }

    private DataGridView CreatePatientsGrid(Hospital hospital)
    {
        var grid = new DataGridView();
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = SystemColors.Window;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        grid.Columns.Add("Id", "Id");
        grid.Columns.Add("HospitalId", "HospitalId");
        grid.Columns.Add("FirstName", "FirstName");
        grid.Columns.Add("LastName", "LastName");
        grid.Columns.Add("DateOfBirth", "DateOfBirth");
        grid.Columns.Add("Disease", "Disease");
        grid.Columns.Add("Department", "Department");
        grid.Columns.Add("DiseaseSeverity", "DiseaseSeverity");
        grid.Columns.Add("IllnessDuration", "IllnessDuration");
        grid.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "DeleteAction",
            HeaderText = "Action",
            Text = "Удалить",
            UseColumnTextForButtonValue = true
        });

        grid.CellContentClick += (_, e) => OnPatientsGridCellContentClick(grid, hospital, e);

        if (hospital.Patients.Count == 0)
        {
            grid.Rows.Add("", "", "Нет пациентов", "", "", "", "", "", "", "");
            return grid;
        }

        foreach (var patient in hospital.Patients)
        {
            grid.Rows.Add(
                patient.Id,
                patient.HospitalId,
                patient.FirstName,
                patient.LastName,
                patient.DateOfBirth.ToShortDateString(),
                patient.Disease,
                patient.Department,
                patient.DiseaseSeverity,
                patient.IllnessDuration,
                "Удалить");
        }

        return grid;
    }

    private void OnPatientsGridCellContentClick(DataGridView grid, Hospital hospital, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
        {
            return;
        }

        if (grid.Columns[e.ColumnIndex].Name != "DeleteAction" || hospital.Patients.Count == 0)
        {
            return;
        }

        var cellValue = grid.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
        if (!int.TryParse(cellValue, out var patientId))
        {
            return;
        }

        var confirmResult = MessageBox.Show(
            $"Удалить пациента с ID {patientId} из больницы {hospital.Name}?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmResult != DialogResult.Yes)
        {
            return;
        }

        if (!_registry.RemovePatient(hospital.Id, patientId, out var error))
        {
            MessageBox.Show(error);
            return;
        }

        RefreshHospitals();
    }

    private static void AddRow(Control container, string label, string value, int y)
    {
        var lblLeft = new Label();
        lblLeft.Text = label;
        lblLeft.Left = 10;
        lblLeft.Top = y;
        lblLeft.Width = 130;

        var lblRight = new Label();
        lblRight.Text = value;
        lblRight.Left = 145;
        lblRight.Top = y;
        lblRight.AutoSize = true;

        container.Controls.Add(lblLeft);
        container.Controls.Add(lblRight);
    }
}
