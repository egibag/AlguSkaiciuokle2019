namespace AlguSkaiciuokle2019
{
    partial class FormPagrindine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagrindine));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUSTATYMAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKAIČIUOKLĖSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaneleFormoje = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUSTATYMAIToolStripMenuItem,
            this.sKAIČIUOKLĖSToolStripMenuItem,
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUSTATYMAIToolStripMenuItem
            // 
            this.nUSTATYMAIToolStripMenuItem.Name = "nUSTATYMAIToolStripMenuItem";
            this.nUSTATYMAIToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.nUSTATYMAIToolStripMenuItem.Text = "NUSTATYMAI";
            this.nUSTATYMAIToolStripMenuItem.Click += new System.EventHandler(this.nUSTATYMAIToolStripMenuItem_Click);
            // 
            // sKAIČIUOKLĖSToolStripMenuItem
            // 
            this.sKAIČIUOKLĖSToolStripMenuItem.Name = "sKAIČIUOKLĖSToolStripMenuItem";
            this.sKAIČIUOKLĖSToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sKAIČIUOKLĖSToolStripMenuItem.Text = "SKAIČIUOKLĖ";
            this.sKAIČIUOKLĖSToolStripMenuItem.Click += new System.EventHandler(this.sKAICIUOKLESToolStripMenuItem_Click);
            // 
            // sKAIČIAVIMŲISTORIJAToolStripMenuItem
            // 
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem.Name = "sKAIČIAVIMŲISTORIJAToolStripMenuItem";
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem.Text = "SKAIČIAVIMŲ ISTORIJA";
            this.sKAIČIAVIMŲISTORIJAToolStripMenuItem.Click += new System.EventHandler(this.sKAIČIAVIMŲISTORIJAToolStripMenuItem_Click);
            // 
            // PaneleFormoje
            // 
            this.PaneleFormoje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaneleFormoje.Location = new System.Drawing.Point(0, 24);
            this.PaneleFormoje.Name = "PaneleFormoje";
            this.PaneleFormoje.Size = new System.Drawing.Size(1065, 660);
            this.PaneleFormoje.TabIndex = 1;
            // 
            // FormPagrindine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 684);
            this.Controls.Add(this.PaneleFormoje);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPagrindine";
            this.Text = "ALGŲ SKAIČIUOKLĖ 2019";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUSTATYMAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sKAIČIUOKLĖSToolStripMenuItem;
        private System.Windows.Forms.Panel PaneleFormoje;
        private System.Windows.Forms.ToolStripMenuItem sKAIČIAVIMŲISTORIJAToolStripMenuItem;
    }
}

