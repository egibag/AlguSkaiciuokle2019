using System;
using System.Windows.Forms;

namespace AlguSkaiciuokle2019
{
    public partial class FormPagrindine : Form
    {
        public FormPagrindine()
        {
            InitializeComponent();
        }

        private void nUSTATYMAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in PaneleFormoje.Controls)
            {
                if (item is Form)
                {
                    var temp = (Form)item; //castinam
                    temp.Close();
                }
            }
            FormNustatymai forma = new FormNustatymai();
            forma.TopLevel = false;
            PaneleFormoje.Controls.Add(forma);
            forma.Show();            
        }

        private void sKAICIUOKLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in PaneleFormoje.Controls)
            {
                if (item is Form)
                {
                    var temp = (Form)item; //castinam
                    temp.Close();
                }
            }

            FormSkaiciuokle forma = new FormSkaiciuokle();
            forma.TopLevel = false;
            PaneleFormoje.Controls.Add(forma);
            forma.Show();
        }

        private void sKAIČIAVIMŲISTORIJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control item in PaneleFormoje.Controls)
            {
                if (item is Form)
                {
                    var temp = (Form)item; //castinam
                    temp.Close();
                }
            }

            FormSkaivimuIstorija forma = new FormSkaivimuIstorija();
            forma.TopLevel = false;
            PaneleFormoje.Controls.Add(forma);
            forma.Show();
        }
    }
}
