
namespace ASE_Assessment
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.RUN = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.InputWindow = new System.Windows.Forms.RichTextBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(176, 40);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 40);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
           
            // 
            // OutputWindow
            // 
            this.OutputWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputWindow.Location = new System.Drawing.Point(670, 58);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(654, 728);
            this.OutputWindow.TabIndex = 4;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputWindow_Paint);
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(31, 703);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(117, 64);
            this.RUN.TabIndex = 5;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            this.RUN.Enter += new System.EventHandler(this.RUN_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(259, 703);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(141, 64);
            this.RESET.TabIndex = 6;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(530, 703);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(116, 64);
            this.CLEAR.TabIndex = 7;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // InputWindow
            // 
            this.InputWindow.Location = new System.Drawing.Point(12, 58);
            this.InputWindow.Name = "InputWindow";
            this.InputWindow.Size = new System.Drawing.Size(634, 451);
            this.InputWindow.TabIndex = 8;
            this.InputWindow.Text = "";
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(100, 554);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(407, 29);
            this.CommandLine.TabIndex = 9;
            this.CommandLine.Click += new System.EventHandler(this.RUN_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.RUN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 813);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.InputWindow);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.RichTextBox InputWindow;
        private System.Windows.Forms.TextBox CommandLine;
    }
}

