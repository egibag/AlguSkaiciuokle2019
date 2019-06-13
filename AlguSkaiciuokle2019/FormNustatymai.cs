using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq;

namespace AlguSkaiciuokle2019
{
    public partial class FormNustatymai : Form
    {

        public FormNustatymai()
        {
            InitializeComponent();
        }

        string connectionString = DbParametraiIsFailo();

        private void FormNustatymai_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            DataContext db = new DataContext(connectionString);
            var lentele = db.GetTable<Mokesciai>().ToList();            

            textBoxSveikDraudTARIF.Text = lentele[0].SveikatosDraudimo.ToString();
            textBoxPensDraudTARIF.Text = lentele[0].PensijuIrSocDraudimo.ToString();
            textBoxPajaMokTARIF.Text = lentele[0].Pajamu.ToString();
            textBoxDarbdavMokTARIF.Text = lentele[0].Darbdavio.ToString();

            textBoxSveikDraudAutorTARIF.Text = lentele[1].SveikatosDraudimo.ToString();
            textBoxPajaMokAutorTARIF.Text = lentele[1].Pajamu.ToString();
        }


        private void buttonIssaugoti_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PatikrintiArTikSkaiciai(textBoxPajaMokTARIF.Text.ToCharArray()))
                {

                    throw new FormatException("Patikrinkite įvedamą informaciją. Galima įvesti tik skaičius!");
                }
                
                DataContext db = new DataContext(connectionString);
                var lentele1 = db.GetTable<Mokesciai>().Where(x => x.Id ==  1).First();
                lentele1.Tipas = "Standartinė";
                lentele1.SveikatosDraudimo = Convert.ToDouble(textBoxSveikDraudTARIF.Text);
                lentele1.PensijuIrSocDraudimo = Convert.ToDouble(textBoxPensDraudTARIF.Text);
                lentele1.Pajamu = Convert.ToDouble(textBoxPajaMokTARIF.Text);
                lentele1.Darbdavio = Convert.ToDouble(textBoxDarbdavMokTARIF.Text);

                var lentele2 = db.GetTable<Mokesciai>().Where(x => x.Id == 2).First();
                lentele2.Tipas = "Autorinė";
                lentele2.SveikatosDraudimo = Convert.ToDouble(textBoxSveikDraudAutorTARIF.Text);                
                lentele2.Pajamu = Convert.ToDouble(textBoxPajaMokTARIF.Text);                

                db.SubmitChanges();
                db.Dispose();

                MessageBox.Show("Vartotojo duomenys išsaugoti");
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void buttonUzdaryti_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool PatikrintiArTikSkaiciai(char[] masyvas)
        {
            bool atsakymas = false;
            foreach (var item in masyvas)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return atsakymas;
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
    }
}
