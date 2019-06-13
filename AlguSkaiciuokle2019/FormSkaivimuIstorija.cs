using System;
using System.Windows.Forms;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AlguSkaiciuokle2019
{
    public partial class FormSkaivimuIstorija : Form
    {
        string connectionString = DbParametraiIsFailo();

        Dictionary<string, Func<Skaiciavimai, bool>> MetoduZodynas;

        public FormSkaivimuIstorija()
        {
            InitializeComponent();
            GetTable();

            comboBoxFiltras.Items.Add("VardasPavarde");
            comboBoxFiltras.Items.Add("Id");
            MetoduZodynas = new Dictionary<string, Func<Skaiciavimai, bool>>
            {
                {"Id", x => x.Id == int.Parse(textBoxPaieska.Text)},
                {"VardasPavarde", x => x.VardasPavarde == textBoxPaieska.Text}
            };
        }

        public static string DbParametraiIsFailo()
        {
            string mokesciuTarifai = null;
            try
            {
                using (System.IO.StreamReader reader = new StreamReader("setup.ini", true))
                {
                    mokesciuTarifai = Convert.ToString(reader.ReadLine());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemos nuskaitant setup.ini failą!");
                MessageBox.Show(ex.Message);
            }
            return mokesciuTarifai;
        }

        private void GetTable()
        {
            DataContext db = new DataContext(connectionString);
            var lentele = db.GetTable<Skaiciavimai>().OrderBy(x => x.VardasPavarde);
            dataGridView1.DataSource = lentele;
        }

        private void textBoxPaieska_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext(connectionString);
                var lentele = db.GetTable<Skaiciavimai>().Where(MetoduZodynas[(string)comboBoxFiltras.SelectedIndex]).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lentele;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepasirinktas filtras");
            }

            
        }
    }
}
