namespace Course_Project_OOP;
using Models;

public partial class MainView : UserControl
{
    private readonly Hospital _hospital;

    public MainView(Hospital hospital)
    {
        InitializeComponent();

        _hospital = hospital;
        RefreshHospital();
    }

    public void RefreshHospital()
    {
        RenderHospital(_hospital);
    }

    private void RenderHospital(Hospital hospital)
    {
        lblHospitalName.Text = hospital.Name;
        flowPatients.Controls.Clear();
        foreach (var patient in hospital.Patients)
        {
            var patientControl = CreatePatientControl(patient);
            flowPatients.Controls.Add(patientControl);
        }
    }

    private Control CreatePatientControl(Patient patient)
    {
        var container = new Panel();
        container.Width = flowPatients.Width - 25;
        container.Height = 120;
        container.BorderStyle = BorderStyle.FixedSingle;

        var lblTitle = new Label();
        lblTitle.Text = $"Пациент ID: {patient.Id}";
        lblTitle.Top = 5;
        lblTitle.Left = 5;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        container.Controls.Add(lblTitle);

        int startY = 30;

        void AddRow(string label, string value, int y)
        {
            var lblLeft = new Label();
            lblLeft.Text = label;
            lblLeft.Left = 10;
            lblLeft.Top = y;
            lblLeft.Width = 120;

            var lblRight = new Label();
            lblRight.Text = value;
            lblRight.Left = 140;
            lblRight.Top = y;
            lblRight.AutoSize = true;

            container.Controls.Add(lblLeft);
            container.Controls.Add(lblRight);
        }

        AddRow("FirstName:", patient.FirstName, startY);
        AddRow("LastName:", patient.LastName, startY + 20);
        AddRow("DateOfBirth:", patient.DateOfBirth.ToShortDateString(), startY + 40);
        AddRow("Diagnosis:", patient.Diagnosis, startY + 60);

        return container;
    }
}
