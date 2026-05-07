using System.ComponentModel;

namespace Course_Project_OOP;

partial class CreateHospitalView
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
        txtId = new System.Windows.Forms.TextBox();
        txtName = new System.Windows.Forms.TextBox();
        txtCapacity = new System.Windows.Forms.TextBox();
        txtOccupiedBeds = new System.Windows.Forms.TextBox();
        cmbHospitalType = new System.Windows.Forms.ComboBox();
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
        tableLayoutPanel1.Controls.Add(txtId, 2, 2);
        tableLayoutPanel1.Controls.Add(txtName, 2, 3);
        tableLayoutPanel1.Controls.Add(txtCapacity, 2, 4);
        tableLayoutPanel1.Controls.Add(txtOccupiedBeds, 2, 5);
        tableLayoutPanel1.Controls.Add(cmbHospitalType, 2, 6);
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
        tableLayoutPanel1.Size = new System.Drawing.Size(900, 520);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Fill;
        label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(233, 125);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(214, 30);
        label1.TabIndex = 0;
        label1.Text = "Регистрация больницы";
        // 
        // label2
        // 
        label2.Dock = System.Windows.Forms.DockStyle.Fill;
        label2.Font = new System.Drawing.Font("Cambria", 12F);
        label2.Location = new System.Drawing.Point(233, 155);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(214, 30);
        label2.TabIndex = 1;
        label2.Text = "ID больницы:";
        // 
        // label3
        // 
        label3.Dock = System.Windows.Forms.DockStyle.Fill;
        label3.Font = new System.Drawing.Font("Cambria", 12F);
        label3.Location = new System.Drawing.Point(233, 185);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(214, 30);
        label3.TabIndex = 2;
        label3.Text = "Название:";
        // 
        // label4
        // 
        label4.Dock = System.Windows.Forms.DockStyle.Fill;
        label4.Font = new System.Drawing.Font("Cambria", 12F);
        label4.Location = new System.Drawing.Point(233, 215);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(214, 30);
        label4.TabIndex = 3;
        label4.Text = "Вместимость:";
        // 
        // label5
        // 
        label5.Dock = System.Windows.Forms.DockStyle.Fill;
        label5.Font = new System.Drawing.Font("Cambria", 12F);
        label5.Location = new System.Drawing.Point(233, 245);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(214, 30);
        label5.TabIndex = 4;
        label5.Text = "Занято мест:";
        // 
        // label6
        // 
        label6.Dock = System.Windows.Forms.DockStyle.Fill;
        label6.Font = new System.Drawing.Font("Cambria", 12F);
        label6.Location = new System.Drawing.Point(233, 275);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(214, 30);
        label6.TabIndex = 5;
        label6.Text = "Тип больницы:";
        // 
        // txtId
        // 
        txtId.Dock = System.Windows.Forms.DockStyle.Fill;
        txtId.Location = new System.Drawing.Point(453, 158);
        txtId.Name = "txtId";
        txtId.Size = new System.Drawing.Size(214, 23);
        txtId.TabIndex = 6;
        // 
        // txtName
        // 
        txtName.Dock = System.Windows.Forms.DockStyle.Fill;
        txtName.Location = new System.Drawing.Point(453, 188);
        txtName.Name = "txtName";
        txtName.Size = new System.Drawing.Size(214, 23);
        txtName.TabIndex = 7;
        // 
        // txtCapacity
        // 
        txtCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
        txtCapacity.Location = new System.Drawing.Point(453, 218);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Size = new System.Drawing.Size(214, 23);
        txtCapacity.TabIndex = 8;
        // 
        // txtOccupiedBeds
        // 
        txtOccupiedBeds.Dock = System.Windows.Forms.DockStyle.Fill;
        txtOccupiedBeds.Location = new System.Drawing.Point(453, 248);
        txtOccupiedBeds.Name = "txtOccupiedBeds";
        txtOccupiedBeds.ReadOnly = true;
        txtOccupiedBeds.Size = new System.Drawing.Size(214, 23);
        txtOccupiedBeds.TabIndex = 9;
        // 
        // cmbHospitalType
        // 
        cmbHospitalType.Dock = System.Windows.Forms.DockStyle.Fill;
        cmbHospitalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbHospitalType.FormattingEnabled = true;
        cmbHospitalType.Items.AddRange(new object[] { "Взрослая", "Детская" });
        cmbHospitalType.Location = new System.Drawing.Point(453, 278);
        cmbHospitalType.Name = "cmbHospitalType";
        cmbHospitalType.Size = new System.Drawing.Size(214, 23);
        cmbHospitalType.TabIndex = 10;
        // 
        // btnAdd
        // 
        btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
        btnAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
        btnAdd.Location = new System.Drawing.Point(233, 308);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(214, 54);
        btnAdd.TabIndex = 11;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // CreateHospitalView
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
    private System.Windows.Forms.ComboBox cmbHospitalType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox txtCapacity;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtOccupiedBeds;

    #endregion
}
