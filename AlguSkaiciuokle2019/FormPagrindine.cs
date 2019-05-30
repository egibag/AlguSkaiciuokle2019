using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlguSkaiciuokle2019
{
    public partial class FormPagrindine : Form
    {
        public FormPagrindine()
        {
            InitializeComponent();
        }

        private void FormPagrindine_Load(object sender, EventArgs e)
        {

        }

        private void nUSTATYMAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNustatymai forma = new FormNustatymai();
            forma.TopLevel = false;
            PaneleFormoje.Controls.Add(forma);
            forma.Show();
        }

        private void sKAICIUOKLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSkaiciuokle forma = new FormSkaiciuokle();
            forma.TopLevel = false;
            PaneleFormoje.Controls.Add(forma);
            //forma.LostFocus += new EventHandler(iseitaIsFormos);
            forma.Show();
        }

        //void iseitaIsFormos(object sender, EventArgs e)
        //{
        //    FormSkaiciuokle forma = new FormSkaiciuokle();
        //    forma.Close();
        //    forma.Dispose();
        //}
    }
}
