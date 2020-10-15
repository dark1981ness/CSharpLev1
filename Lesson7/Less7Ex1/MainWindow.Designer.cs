namespace Less7Ex1
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Programms = new System.Windows.Forms.ToolStripMenuItem();
            this.Doubler = new System.Windows.Forms.ToolStripMenuItem();
            this.GuessNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Programms,
            this.About});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(490, 33);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "mainMenu";
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.File.ForeColor = System.Drawing.SystemColors.Control;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(69, 29);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 30);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Programms
            // 
            this.Programms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Doubler,
            this.GuessNumber});
            this.Programms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Programms.ForeColor = System.Drawing.SystemColors.Control;
            this.Programms.Name = "Programms";
            this.Programms.Size = new System.Drawing.Size(127, 29);
            this.Programms.Text = "Программы";
            // 
            // Doubler
            // 
            this.Doubler.ForeColor = System.Drawing.SystemColors.Control;
            this.Doubler.Name = "Doubler";
            this.Doubler.Size = new System.Drawing.Size(200, 30);
            this.Doubler.Text = "Удвоитель";
            this.Doubler.Click += new System.EventHandler(this.Doubler_Click);
            // 
            // GuessNumber
            // 
            this.GuessNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.GuessNumber.Name = "GuessNumber";
            this.GuessNumber.Size = new System.Drawing.Size(200, 30);
            this.GuessNumber.Text = "Угадай число";
            this.GuessNumber.Click += new System.EventHandler(this.GuessNumber_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.About.ForeColor = System.Drawing.SystemColors.Control;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(140, 29);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 33);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(490, 497);
            this.mainPanel.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(490, 530);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Programms;
        private System.Windows.Forms.ToolStripMenuItem Doubler;
        private System.Windows.Forms.ToolStripMenuItem GuessNumber;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Panel mainPanel;
    }
}