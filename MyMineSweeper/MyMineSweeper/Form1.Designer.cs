namespace MyMineSweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            nEWGAMEToolStripMenuItem = new ToolStripMenuItem();
            sTARTToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            aBOUTToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(294, 314);
            button1.Name = "button1";
            button1.Size = new Size(22, 20);
            button1.TabIndex = 0;
            button1.Text = "B";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nEWGAMEToolStripMenuItem, aBOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nEWGAMEToolStripMenuItem
            // 
            nEWGAMEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sTARTToolStripMenuItem, eXITToolStripMenuItem });
            nEWGAMEToolStripMenuItem.Name = "nEWGAMEToolStripMenuItem";
            nEWGAMEToolStripMenuItem.Size = new Size(81, 20);
            nEWGAMEToolStripMenuItem.Text = "NEW GAME";
            // 
            // sTARTToolStripMenuItem
            // 
            sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            sTARTToolStripMenuItem.Size = new Size(105, 22);
            sTARTToolStripMenuItem.Text = "START";
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(105, 22);
            eXITToolStripMenuItem.Text = "EXIT";
            // 
            // aBOUTToolStripMenuItem
            // 
            aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            aBOUTToolStripMenuItem.Size = new Size(57, 20);
            aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // button2
            // 
            button2.Location = new Point(322, 314);
            button2.Name = "button2";
            button2.Size = new Size(22, 20);
            button2.TabIndex = 2;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "MyMineSweeper";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nEWGAMEToolStripMenuItem;
        private ToolStripMenuItem sTARTToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem aBOUTToolStripMenuItem;
        private Button button2;
    }
}
