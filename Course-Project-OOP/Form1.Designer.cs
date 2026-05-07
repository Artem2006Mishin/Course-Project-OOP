namespace Course_Project_OOP;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        добавитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        добавитьБольницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pnlContent = new System.Windows.Forms.Panel();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            главнаяToolStripMenuItem,
            добавитьПациентаToolStripMenuItem,
            добавитьБольницуToolStripMenuItem
        });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(900, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // главнаяToolStripMenuItem
        // 
        главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
        главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
        главнаяToolStripMenuItem.Text = "&Главная";
        главнаяToolStripMenuItem.Click += главнаяToolStripMenuItem_Click;
        // 
        // добавитьПациентаToolStripMenuItem
        // 
        добавитьПациентаToolStripMenuItem.Name = "добавитьПациентаToolStripMenuItem";
        добавитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
        добавитьПациентаToolStripMenuItem.Text = "&Добавить пациента";
        добавитьПациентаToolStripMenuItem.Click += добавитьПациентаToolStripMenuItem_Click;
        // 
        // добавитьБольницуToolStripMenuItem
        // 
        добавитьБольницуToolStripMenuItem.Name = "добавитьБольницуToolStripMenuItem";
        добавитьБольницуToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
        добавитьБольницуToolStripMenuItem.Text = "Д&обавить больницу";
        добавитьБольницуToolStripMenuItem.Click += добавитьБольницуToolStripMenuItem_Click;
        // 
        // pnlContent
        // 
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 24);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new System.Drawing.Size(900, 520);
        pnlContent.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(900, 544);
        Controls.Add(pnlContent);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Hospital Manager";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem добавитьБольницуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem добавитьПациентаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.Panel pnlContent;

    #endregion
}
