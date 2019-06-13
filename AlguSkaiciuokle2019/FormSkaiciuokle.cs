using System;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlguSkaiciuokle2019
{
    public partial class FormSkaiciuokle : Form
    {
        public FormSkaiciuokle()
        {
            InitializeComponent();

            groupBoxAutorine.Visible = false;
            groupBoxAutorine2tab.Visible = false;
            textAlgaIRankasGALUTINE.Visible = false;
            labelAlgaIRAnkasGalutine.Visible = false;
            textAlgaAntPopieriausGALUTINE2tab.Visible = false;
            labelAlgaIRAnkasGalutine2tab.Visible = false;           
        }

        string connectionString = DbParametraiIsFailo();

        private void FormSkaiciuokle_Load_1(object sender, EventArgs e)
        {
            GetData();
            textTarifasVISO.Text =
                (double.Parse(textPensDraudTARIF.Text) +
                 double.Parse(textPajaMokTARIF.Text) +
                 double.Parse(textDarbdavMokTARIF.Text) +
                 double.Parse(textSveikDraudTARIF.Text)).ToString();
            textTarifasVISO2tab.Text = textTarifasVISO.Text;

            textAutorVisoTARIF.Text =
                (double.Parse(textSveikDraudAutorTARIF.Text) +
                 double.Parse(textPajaMokAutorTARIF.Text)).ToString();
            textAutorVisoTARIF2tab.Text = textAutorVisoTARIF.Text;
        }

        public void GetData()
        {
            DataContext db = new DataContext(connectionString);
            var lentele = db.GetTable<Mokesciai>().ToList();

            textSveikDraudTARIF.Text = lentele[0].SveikatosDraudimo.ToString();
            textSveikDraudTARIF2tab.Text = lentele[0].SveikatosDraudimo.ToString();

            textPensDraudTARIF.Text = lentele[0].PensijuIrSocDraudimo.ToString();
            textPensDraudTARIF2tab.Text = lentele[0].PensijuIrSocDraudimo.ToString();

            textPajaMokTARIF.Text = lentele[0].Pajamu.ToString();
            textPajaMokTARIF2tab.Text = lentele[0].Pajamu.ToString();

            textDarbdavMokTARIF.Text = lentele[0].Darbdavio.ToString();
            textDarbdavMokTARIF2tab.Text = lentele[0].Darbdavio.ToString();

            
            textSveikDraudAutorTARIF.Text = lentele[1].SveikatosDraudimo.ToString();
            textSveikDraudAutorTARIF2tab.Text = lentele[1].SveikatosDraudimo.ToString();

            textPajaMokAutorTARIF.Text = lentele[1].Pajamu.ToString();
            textPajaMokAutorTARIF2tab.Text = lentele[1].Pajamu.ToString();
        }


        private void textBoxAlgaAntPopieriaus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textSveikDraud.Text =
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) *
                     double.Parse(textSveikDraudTARIF.Text) / 100).ToString();
                textPensDraud.Text =
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) *
                     double.Parse(textPensDraudTARIF.Text) / 100).ToString();
                textPajaMok.Text =
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) *
                     double.Parse(textPajaMokTARIF.Text) / 100).ToString();
                textDarbdavMok.Text =
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) *
                     double.Parse(textDarbdavMokTARIF.Text) / 100).ToString();
                textMokViso.Text = 
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) *
                     double.Parse(textTarifasVISO.Text) / 100).ToString();
                textAlgaIRankasViso.Text =
                    (double.Parse(textBoxAlgaAntPopieriaus.Text) -
                     double.Parse(textMokViso.Text)).ToString();

                if (checkBoxAUTORINE.Checked == true)
                {
                    textAlgaIRankasGALUTINE.Text =
                    (double.Parse(textAlgaIRankasViso.Text) +
                    double.Parse(textAAlgaIRankas.Text)).ToString();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Įveskite sumą!");
            }
        }

        private void checkBoxAUTORINE_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAUTORINE.Checked == true)
            {
                groupBoxAutorine.Visible = true;
                textAlgaIRankasGALUTINE.Visible = true;
                labelAlgaIRAnkasGalutine.Visible = true;
            }

            if (checkBoxAUTORINE.Checked == false)
            {
                groupBoxAutorine.Visible = false;
                textAlgaIRankasGALUTINE.Visible = false;
                labelAlgaIRAnkasGalutine.Visible = false;
            }
        }

        private void textBoxAAlgaAntPopieriaus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textSveikDraudAUTOR.Text =
                    (double.Parse(textBoxAAlgaAntPopieriaus.Text) *
                     double.Parse(textSveikDraudAutorTARIF.Text) / 100).ToString();
                textPajamMokAUTOR.Text =
                    (double.Parse(textBoxAAlgaAntPopieriaus.Text) *
                     double.Parse(textPajaMokTARIF.Text) / 100).ToString();
                textMokVisoAutor.Text =
                    (double.Parse(textBoxAAlgaAntPopieriaus.Text) *
                     double.Parse(textAutorVisoTARIF.Text) / 100).ToString();

                textAAlgaIRankas.Text =
                    (double.Parse(textBoxAAlgaAntPopieriaus.Text) -
                     double.Parse(textMokVisoAutor.Text)).ToString();

                textAlgaIRankasGALUTINE.Text =
                    (double.Parse(textAlgaIRankasViso.Text) +
                    double.Parse(textAAlgaIRankas.Text)).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Įveskite sumą.");
            }
        }

        // 2 tabas
        private void textBoxAlgaPoMok_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textSveikDraud2tab.Text =                    
                    (double.Parse(textBoxAlgaPoMok.Text) / ((100 -
                     double.Parse(textSveikDraudTARIF2tab.Text)) / 100) *
                     double.Parse(textSveikDraudTARIF2tab.Text) / 100).ToString("#");

                textPensDraud2tab.Text =
                    (double.Parse(textBoxAlgaPoMok.Text) / ((100 -
                     double.Parse(textPensDraudTARIF.Text)) / 100) *
                     double.Parse(textPensDraudTARIF.Text) / 100).ToString("#");
                textPajaMok2tab.Text =
                    (double.Parse(textBoxAlgaPoMok.Text) / ((100 -
                     double.Parse(textPajaMokTARIF.Text)) / 100) *
                     double.Parse(textPajaMokTARIF.Text) / 100).ToString("#");                    
                textDarbdavMok2tab.Text =
                    (double.Parse(textBoxAlgaPoMok.Text) / ((100 -
                     double.Parse(textDarbdavMokTARIF.Text)) / 100) *
                     double.Parse(textDarbdavMokTARIF.Text) / 100).ToString("#");

                textMokViso2tab.Text =
                    (double.Parse(textBoxAlgaPoMok.Text) / ((100 -
                     double.Parse(textTarifasVISO.Text)) / 100) *
                     double.Parse(textTarifasVISO.Text) / 100).ToString("#");

                textAlgaAntPopieriausViso2tab.Text =
                    (double.Parse(textBoxAlgaPoMok.Text) +
                     double.Parse(textMokViso2tab.Text)).ToString("#");

                if (checkBoxAUTORINE2tab.Checked == true)
                {
                    textAlgaAntPopieriausGALUTINE2tab.Text =
                    (double.Parse(textAlgaAntPopieriausViso2tab.Text) +
                    double.Parse(textAAlgaIRankas2tab.Text)).ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Įveskite sumą!");
            }
        }

        private void checkBoxAUTORINE2tab_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAUTORINE2tab.Checked == true)
            {
                groupBoxAutorine2tab.Visible = true;
                textAlgaAntPopieriausGALUTINE2tab.Visible = true;
                labelAlgaIRAnkasGalutine2tab.Visible = true;
            }

            if (checkBoxAUTORINE2tab.Checked == false)
            {
                groupBoxAutorine2tab.Visible = false;
                textAlgaAntPopieriausGALUTINE2tab.Visible = false;
                labelAlgaIRAnkasGalutine2tab.Visible = false;
            }
        }

        // 2 tabas
        private void textBoxAAlgaPoMokesciu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textSveikDraudAUTOR2tab.Text =
                    (double.Parse(textBoxAAlgaIRankas.Text) / ((100 -
                     double.Parse(textSveikDraudAutorTARIF2tab.Text)) / 100) *
                     double.Parse(textSveikDraudAutorTARIF2tab.Text) / 100).ToString("#");
                textPajamMokAUTOR2tab.Text =
                    (double.Parse(textBoxAAlgaIRankas.Text) / ((100 -
                     double.Parse(textPajaMokAutorTARIF2tab.Text)) / 100) *
                     double.Parse(textPajaMokAutorTARIF2tab.Text) / 100).ToString("#");
                textMokVisoAutor2tab.Text =
                    (double.Parse(textBoxAAlgaIRankas.Text) / ((100 -
                     double.Parse(textAutorVisoTARIF.Text)) / 100) *
                     double.Parse(textAutorVisoTARIF.Text) / 100).ToString("#");

                textAAlgaIRankas2tab.Text =
                    (double.Parse(textBoxAAlgaIRankas.Text) +
                     double.Parse(textMokVisoAutor2tab.Text)).ToString();

                textAlgaAntPopieriausGALUTINE2tab.Text =
                    (double.Parse(textAlgaAntPopieriausViso2tab.Text) +
                     double.Parse(textAAlgaIRankas2tab.Text)).ToString();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Įveskite sumą.");
            }
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

        private void buttonIsaugotiSkaiciavimus_Click(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext(connectionString);
                var table = db.GetTable<Skaiciavimai>();
                Skaiciavimai skaiciavStand = new Skaiciavimai();
                skaiciavStand.VardasPavarde = textBoxVardasPavarde.Text;
                skaiciavStand.DarbuotojoId = 0;
                skaiciavStand.EurAlgaAntPopieriaus = Convert.ToDouble(textBoxAlgaAntPopieriaus.Text);
                skaiciavStand.EurAlgaIRankas = Convert.ToDouble(textAlgaIRankasViso.Text);

                skaiciavStand.EurAAlgaAntPopieriaus = Convert.ToDouble(textBoxAAlgaAntPopieriaus.Text);
                skaiciavStand.EurAAlgaIRankas = Convert.ToDouble(textAAlgaIRankas.Text);

                skaiciavStand.EurSveikatosDraudimo = Convert.ToDouble(textSveikDraud.Text);
                skaiciavStand.EurPensijuIrSocDraudimo = Convert.ToDouble(textPensDraud.Text);

                skaiciavStand.EurPajamu = Convert.ToDouble(textPajaMok.Text);
                skaiciavStand.EurDarbdavio = Convert.ToDouble(textDarbdavMok.Text);

                skaiciavStand.EurAutorSveikatosDraudimo = Convert.ToDouble(textSveikDraudAUTOR.Text);
                skaiciavStand.EurAutorPajamu = Convert.ToDouble(textPajamMokAUTOR.Text);

                skaiciavStand.SveikatosDraudimo = Convert.ToDouble(textSveikDraudTARIF.Text);
                skaiciavStand.PensijuIrSocDraudimo = Convert.ToDouble(textPensDraudTARIF.Text);

                skaiciavStand.Pajamu = Convert.ToDouble(textPajaMokTARIF.Text);
                skaiciavStand.Darbdavio = Convert.ToDouble(textDarbdavMokTARIF.Text);

                skaiciavStand.AutorSveikatosDraudimo = Convert.ToDouble(textSveikDraudAutorTARIF.Text);
                skaiciavStand.AutorPajamu = Convert.ToDouble(textPajaMokTARIF.Text);

                table.InsertOnSubmit(skaiciavStand);
                db.SubmitChanges();
                db.Dispose();
              
                MessageBox.Show("Skaiciavimo duomenys išsaugoti.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nepavyko išsaugoti skaičiavimų!");
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
