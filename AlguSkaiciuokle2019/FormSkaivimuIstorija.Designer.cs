namespace AlguSkaiciuokle2019
{
    partial class FormSkaivimuIstorija
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPaieska = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxFiltras
            // 
            this.comboBoxFiltras.FormattingEnabled = true;
            this.comboBoxFiltras.Location = new System.Drawing.Point(232, 25);
            this.comboBoxFiltras.Name = "comboBoxFiltras";
            this.comboBoxFiltras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtruoti pagal stulpelį:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtruoti pagal tekstą stulpelyje:";
            // 
            // textBoxPaieska
            // 
            this.textBoxPaieska.Location = new System.Drawing.Point(232, 52);
            this.textBoxPaieska.Name = "textBoxPaieska";
            this.textBoxPaieska.Size = new System.Drawing.Size(121, 20);
            this.textBoxPaieska.TabIndex = 4;
            this.textBoxPaieska.TextChanged += new System.EventHandler(this.textBoxPaieska_TextChanged);
            // 
            // FormSkaivimuIstorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.textBoxPaieska);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltras);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSkaivimuIstorija";
            this.Text = "FormSkaivimuIstorija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxFiltras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPaieska;
    }
}