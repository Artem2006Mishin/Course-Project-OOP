using System.ComponentModel;

namespace Course_Project_OOP;

partial class MainView
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        lblHospitalName = new System.Windows.Forms.Label();
        flowPatients = new System.Windows.Forms.FlowLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(lblHospitalName, 1, 1);
        tableLayoutPanel1.Controls.Add(flowPatients, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(800, 442);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // lblHospitalName
        // 
        lblHospitalName.Dock = System.Windows.Forms.DockStyle.Fill;
        lblHospitalName.Font = new System.Drawing.Font("Cambria", 12F);
        lblHospitalName.Location = new System.Drawing.Point(203, 71);
        lblHospitalName.Name = "lblHospitalName";
        lblHospitalName.Size = new System.Drawing.Size(394, 30);
        lblHospitalName.TabIndex = 0;
        lblHospitalName.Text = "label1";
        // 
        // flowPatients
        // 
        flowPatients.AutoScroll = true;
        flowPatients.Dock = System.Windows.Forms.DockStyle.Fill;
        flowPatients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        flowPatients.Location = new System.Drawing.Point(203, 104);
        flowPatients.Name = "flowPatients";
        flowPatients.Size = new System.Drawing.Size(394, 264);
        flowPatients.TabIndex = 1;
        flowPatients.WrapContents = false;
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        Controls.Add(tableLayoutPanel1);
        Location = new System.Drawing.Point(15, 15);
        Size = new System.Drawing.Size(800, 442);
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblHospitalName;
    private System.Windows.Forms.FlowLayoutPanel flowPatients;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}