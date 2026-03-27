using System.ComponentModel;

namespace Course_Project_OOP;

partial class CreatePatientView
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        txtId = new System.Windows.Forms.TextBox();
        txtFirstName = new System.Windows.Forms.TextBox();
        txtLastName = new System.Windows.Forms.TextBox();
        txtDiagnosis = new System.Windows.Forms.TextBox();
        dtpBirth = new System.Windows.Forms.DateTimePicker();
        btnAdd = new System.Windows.Forms.Button();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(label1, 1, 1);
        tableLayoutPanel1.Controls.Add(label2, 1, 2);
        tableLayoutPanel1.Controls.Add(label3, 1, 3);
        tableLayoutPanel1.Controls.Add(label4, 1, 4);
        tableLayoutPanel1.Controls.Add(label5, 1, 5);
        tableLayoutPanel1.Controls.Add(label6, 1, 6);
        tableLayoutPanel1.Controls.Add(txtId, 2, 2);
        tableLayoutPanel1.Controls.Add(txtFirstName, 2, 3);
        tableLayoutPanel1.Controls.Add(txtLastName, 2, 4);
        tableLayoutPanel1.Controls.Add(txtDiagnosis, 2, 6);
        tableLayoutPanel1.Controls.Add(dtpBirth, 2, 5);
        tableLayoutPanel1.Controls.Add(btnAdd, 1, 7);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 9;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(800, 442);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(203, 101);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(194, 30);
        label1.TabIndex = 0;
        label1.Text = "Регистрация пациента";
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Cambria", 12F);
        label2.Location = new System.Drawing.Point(203, 131);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(194, 30);
        label2.TabIndex = 1;
        label2.Text = "ID:";
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Cambria", 12F);
        label3.Location = new System.Drawing.Point(203, 161);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(194, 30);
        label3.TabIndex = 2;
        label3.Text = "Имя:";
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Cambria", 12F);
        label4.Location = new System.Drawing.Point(203, 191);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(194, 30);
        label4.TabIndex = 3;
        label4.Text = "Фамилия:";
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Font = new System.Drawing.Font("Cambria", 12F);
        label5.Location = new System.Drawing.Point(203, 221);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(194, 30);
        label5.TabIndex = 4;
        label5.Text = "Дата рождения:";
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Cambria", 12F);
        label6.Location = new System.Drawing.Point(203, 251);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(194, 30);
        label6.TabIndex = 5;
        label6.Text = "Диагноз:";
        // 
        // txtId
        // 
        txtId.Dock = System.Windows.Forms.DockStyle.Fill;
        txtId.Location = new System.Drawing.Point(403, 134);
        txtId.Name = "txtId";
        txtId.Size = new System.Drawing.Size(194, 23);
        txtId.TabIndex = 6;
        // 
        // txtFirstName
        // 
        txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
        txtFirstName.Location = new System.Drawing.Point(403, 164);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new System.Drawing.Size(194, 23);
        txtFirstName.TabIndex = 7;
        // 
        // txtLastName
        // 
        txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
        txtLastName.Location = new System.Drawing.Point(403, 194);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new System.Drawing.Size(194, 23);
        txtLastName.TabIndex = 8;
        // 
        // txtDiagnosis
        // 
        txtDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
        txtDiagnosis.Location = new System.Drawing.Point(403, 254);
        txtDiagnosis.Name = "txtDiagnosis";
        txtDiagnosis.Size = new System.Drawing.Size(194, 23);
        txtDiagnosis.TabIndex = 9;
        // 
        // dtpBirth
        // 
        dtpBirth.Dock = System.Windows.Forms.DockStyle.Fill;
        dtpBirth.Location = new System.Drawing.Point(403, 224);
        dtpBirth.Name = "dtpBirth";
        dtpBirth.Size = new System.Drawing.Size(194, 23);
        dtpBirth.TabIndex = 10;
        // 
        // btnAdd
        // 
        btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        btnAdd.Location = new System.Drawing.Point(203, 284);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(194, 54);
        btnAdd.TabIndex = 11;
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
        Size = new System.Drawing.Size(800, 442);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnAdd;

    private System.Windows.Forms.DateTimePicker dtpBirth;

    private System.Windows.Forms.TextBox txtDiagnosis;

    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtLastName;

    private System.Windows.Forms.TextBox txtId;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}