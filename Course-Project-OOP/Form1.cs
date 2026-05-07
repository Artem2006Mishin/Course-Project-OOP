namespace Course_Project_OOP;
using Models;

public partial class Form1 : Form
{
    private readonly HospitalRegistry _registry;
    private readonly MainView _mainView;
    private readonly CreatePatientView _createPatientView;
    private readonly CreateHospitalView _createHospitalView;

    public Form1()
    {
        InitializeComponent();

        _registry = new HospitalRegistry();
        _mainView = new MainView(_registry);
        _createPatientView = new CreatePatientView(_registry);
        _createHospitalView = new CreateHospitalView(_registry);

        _createPatientView.PatientAdded += DataChanged;
        _createHospitalView.HospitalAdded += DataChanged;

        ShowView(_mainView);
    }

    private void ShowView(UserControl view)
    {
        pnlContent.Controls.Clear();
        view.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(view);

        if (view == _mainView)
        {
            _mainView.RefreshHospitals();
        }
    }

    private void DataChanged(object? sender, EventArgs e)
    {
        _mainView.RefreshHospitals();
    }

    private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowView(_mainView);
    }

    private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowView(_createPatientView);
    }

    private void добавитьБольницуToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowView(_createHospitalView);
    }
}
