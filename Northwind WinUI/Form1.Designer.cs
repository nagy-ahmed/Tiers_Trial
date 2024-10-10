namespace Northwind_WinUI
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuPageDown = new ToolStripMenuItem();
            toolStripMenuPageUP = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 426);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem, toolStripMenuPageDown, toolStripMenuPageUP });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripMenuPageDown
            // 
            toolStripMenuPageDown.AccessibleName = "";
            toolStripMenuPageDown.Name = "toolStripMenuPageDown";
            toolStripMenuPageDown.Size = new Size(27, 20);
            toolStripMenuPageDown.Text = "<";
            toolStripMenuPageDown.Click += toolStripMenuPageDown_Click;
            // 
            // toolStripMenuPageUP
            // 
            toolStripMenuPageUP.AccessibleName = "";
            toolStripMenuPageUP.Name = "toolStripMenuPageUP";
            toolStripMenuPageUP.Size = new Size(27, 20);
            toolStripMenuPageUP.Text = ">";
            toolStripMenuPageUP.Click += toolStripMenuPageUP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuPageDown;
        private ToolStripMenuItem toolStripMenuPageUP;
    }
}
