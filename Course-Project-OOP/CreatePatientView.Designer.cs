using System.ComponentModel;

namespace Course_Project_OOP;

partial class CreatePatientView
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        txtId = new System.Windows.Forms.TextBox();
        txtHospitalId = new System.Windows.Forms.TextBox();
        txtFirstName = new System.Windows.Forms.TextBox();
        txtLastName = new System.Windows.Forms.TextBox();
        dtpBirth = new System.Windows.Forms.DateTimePicker();
        txtDisease = new System.Windows.Forms.TextBox();
        txtDepartment = new System.Windows.Forms.TextBox();
        txtDiseaseSeverity = new System.Windows.Forms.TextBox();
        txtIllnessDuration = new System.Windows.Forms.TextBox();
        btnAdd = new System.Windows.Forms.Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(label1, 1, 1);
        tableLayoutPanel1.Controls.Add(label2, 1, 2);
        tableLayoutPanel1.Controls.Add(label3, 1, 3);
        tableLayoutPanel1.Controls.Add(label4, 1, 4);
        tableLayoutPanel1.Controls.Add(label5, 1, 5);
        tableLayoutPanel1.Controls.Add(label6, 1, 6);
        tableLayoutPanel1.Controls.Add(label7, 1, 7);
        tableLayoutPanel1.Controls.Add(label8, 1, 8);
        tableLayoutPanel1.Controls.Add(label9, 1, 9);
        tableLayoutPanel1.Controls.Add(label10, 1, 10);
        tableLayoutPanel1.Controls.Add(txtId, 2, 2);
        tableLayoutPanel1.Controls.Add(txtHospitalId, 2, 3);
        tableLayoutPanel1.Controls.Add(txtFirstName, 2, 4);
        tableLayoutPanel1.Controls.Add(txtLastName, 2, 5);
        tableLayoutPanel1.Controls.Add(dtpBirth, 2, 6);
        tableLayoutPanel1.Controls.Add(txtDisease, 2, 7);
        tableLayoutPanel1.Controls.Add(txtDepartment, 2, 8);
        tableLayoutPanel1.Controls.Add(txtDiseaseSeverity, 2, 9);
        tableLayoutPanel1.Controls.Add(txtIllnessDuration, 2, 10);
        tableLayoutPanel1.Controls.Add(btnAdd, 1, 11);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 13;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(900, 520);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(233, 80);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(214, 30);
        label1.TabIndex = 0;
        label1.Text = "Регистрация пациента";
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Cambria", 12F);
        label2.Location = new System.Drawing.Point(233, 110);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(214, 30);
        label2.TabIndex = 1;
        label2.Text = "ID пациента:";
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Cambria", 12F);
        label3.Location = new System.Drawing.Point(233, 140);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(214, 30);
        label3.TabIndex = 2;
        label3.Text = "ID больницы:";
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Cambria", 12F);
        label4.Location = new System.Drawing.Point(233, 170);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(214, 30);
        label4.TabIndex = 3;
        label4.Text = "Имя:";
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Font = new System.Drawing.Font("Cambria", 12F);
        label5.Location = new System.Drawing.Point(233, 200);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(214, 30);
        label5.TabIndex = 4;
        label5.Text = "Фамилия:";
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Cambria", 12F);
        label6.Location = new System.Drawing.Point(233, 230);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(214, 30);
        label6.TabIndex = 5;
        label6.Text = "Дата рождения:";
        // 
        // label7
        // 
        label7.Dock = System.Windows.Forms.DockStyle.Fill;
        label7.Font = new System.Drawing.Font("Cambria", 12F);
        label7.Location = new System.Drawing.Point(233, 260);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(214, 30);
        label7.TabIndex = 6;
        label7.Text = "Заболевание:";
        // 
        // label8
        // 
        label8.Dock = System.Windows.Forms.DockStyle.Fill;
        label8.Font = new System.Drawing.Font("Cambria", 12F);
        label8.Location = new System.Drawing.Point(233, 290);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(214, 30);
        label8.TabIndex = 7;
        label8.Text = "Отделение:";
        // 
        // label9
        // 
        label9.Dock = System.Windows.Forms.DockStyle.Fill;
        label9.Font = new System.Drawing.Font("Cambria", 12F);
        label9.Location = new System.Drawing.Point(233, 320);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(214, 30);
        label9.TabIndex = 8;
        label9.Text = "Сложность заболевания:";
        // 
        // label10
        // 
        label10.Dock = System.Windows.Forms.DockStyle.Fill;
        label10.Font = new System.Drawing.Font("Cambria", 12F);
        label10.Location = new System.Drawing.Point(233, 350);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(214, 30);
        label10.TabIndex = 9;
        label10.Text = "Продолжительность болезни:";
        // 
        // txtId
        // 
        txtId.Dock = System.Windows.Forms.DockStyle.Fill;
        txtId.Location = new System.Drawing.Point(453, 113);
        txtId.Name = "txtId";
        txtId.Size = new System.Drawing.Size(214, 23);
        txtId.TabIndex = 10;
        // 
        // txtHospitalId
        // 
        txtHospitalId.Dock = System.Windows.Forms.DockStyle.Fill;
        txtHospitalId.Location = new System.Drawing.Point(453, 143);
        txtHospitalId.Name = "txtHospitalId";
        txtHospitalId.Size = new System.Drawing.Size(214, 23);
        txtHospitalId.TabIndex = 11;
        // 
        // txtFirstName
        // 
        txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
        txtFirstName.Location = new System.Drawing.Point(453, 173);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new System.Drawing.Size(214, 23);
        txtFirstName.TabIndex = 12;
        // 
        // txtLastName
        // 
        txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
        txtLastName.Location = new System.Drawing.Point(453, 203);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new System.Drawing.Size(214, 23);
        txtLastName.TabIndex = 13;
        // 
        // dtpBirth
        // 
        dtpBirth.Dock = System.Windows.Forms.DockStyle.Fill;
        dtpBirth.Location = new System.Drawing.Point(453, 233);
        dtpBirth.Name = "dtpBirth";
        dtpBirth.Size = new System.Drawing.Size(214, 23);
        dtpBirth.TabIndex = 14;
        // 
        // txtDisease
        // 
        txtDisease.Dock = System.Windows.Forms.DockStyle.Fill;
        txtDisease.Location = new System.Drawing.Point(453, 263);
        txtDisease.Name = "txtDisease";
        txtDisease.Size = new System.Drawing.Size(214, 23);
        txtDisease.TabIndex = 15;
        // 
        // txtDepartment
        // 
        txtDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
        txtDepartment.Location = new System.Drawing.Point(453, 293);
        txtDepartment.Name = "txtDepartment";
        txtDepartment.Size = new System.Drawing.Size(214, 23);
        txtDepartment.TabIndex = 16;
        // 
        // txtDiseaseSeverity
        // 
        txtDiseaseSeverity.Dock = System.Windows.Forms.DockStyle.Fill;
        txtDiseaseSeverity.Location = new System.Drawing.Point(453, 323);
        txtDiseaseSeverity.Name = "txtDiseaseSeverity";
        txtDiseaseSeverity.Size = new System.Drawing.Size(214, 23);
        txtDiseaseSeverity.TabIndex = 17;
        // 
        // txtIllnessDuration
        // 
        txtIllnessDuration.Dock = System.Windows.Forms.DockStyle.Fill;
        txtIllnessDuration.Location = new System.Drawing.Point(453, 353);
        txtIllnessDuration.Name = "txtIllnessDuration";
        txtIllnessDuration.Size = new System.Drawing.Size(214, 23);
        txtIllnessDuration.TabIndex = 18;
        // 
        // btnAdd
        // 
        btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        btnAdd.Location = new System.Drawing.Point(233, 383);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(214, 54);
        btnAdd.TabIndex = 19;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // CreatePatientView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ActiveCaption;
        Controls.Add(tableLayoutPanel1);
        Size = new System.Drawing.Size(900, 520);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.DateTimePicker dtpBirth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox txtDepartment;
    private System.Windows.Forms.TextBox txtDisease;
    private System.Windows.Forms.TextBox txtDiseaseSeverity;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtHospitalId;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtIllnessDuration;
    private System.Windows.Forms.TextBox txtLastName;

    #endregion
}
