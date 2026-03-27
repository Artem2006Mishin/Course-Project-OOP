namespace Course_Project_OOP;
using Models;

public partial class Form1 : Form
{
    private readonly Hospital _hospital;
    private readonly MainView _view1;
    private readonly CreatePatientView _view2;

    public Form1()
    {
        InitializeComponent();
        
        var hospital = new Hospital("Больница Рахманинова", 10);
        _hospital = hospital;
        _view1 = new MainView(_hospital);
        _view2 = new CreatePatientView(_hospital);
        _view2.PatientAdded += View2_PatientAdded;
        
        ShowView(_view1);
    }

    private void ShowView(UserControl view)
    {
        pnlContent.Controls.Clear();
        view.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(view);

        if (view == _view1)
        {
            _view1.RefreshHospital();
        }
    }

    private void View2_PatientAdded(object? sender, EventArgs e)
    {
        _view1.RefreshHospital();
    }
    
    private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowView(_view1);
    }

    private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowView(_view2);
    }
}
