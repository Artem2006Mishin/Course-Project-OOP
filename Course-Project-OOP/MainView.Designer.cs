using System.ComponentModel;

namespace Course_Project_OOP;

partial class MainView
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        lblTitle = new System.Windows.Forms.Label();
        flowHospitals = new System.Windows.Forms.FlowLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 760F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(lblTitle, 1, 1);
        tableLayoutPanel1.Controls.Add(flowHospitals, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(900, 520);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        lblTitle.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(73, 50);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(754, 40);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Больницы";
        // 
        // flowHospitals
        // 
        flowHospitals.AutoScroll = true;
        flowHospitals.Dock = System.Windows.Forms.DockStyle.Fill;
        flowHospitals.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        flowHospitals.Location = new System.Drawing.Point(73, 93);
        flowHospitals.Name = "flowHospitals";
        flowHospitals.Size = new System.Drawing.Size(754, 374);
        flowHospitals.TabIndex = 1;
        flowHospitals.WrapContents = false;
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(900, 520);
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.FlowLayoutPanel flowHospitals;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
