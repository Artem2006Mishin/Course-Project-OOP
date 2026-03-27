namespace Course_Project_OOP;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pnlContent = new System.Windows.Forms.Panel();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { главнаяToolStripMenuItem, добавитьToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
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
        // добавитьToolStripMenuItem
        // 
        добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
        добавитьToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
        добавитьToolStripMenuItem.Text = "&Добавить пациента";
        добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
        // 
        // pnlContent
        // 
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(0, 24);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new System.Drawing.Size(800, 442);
        pnlContent.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 466);
        Controls.Add(pnlContent);
        Controls.Add(menuStrip1);
        Location = new System.Drawing.Point(15, 15);
        MainMenuStrip = menuStrip1;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel pnlContent;

    private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}