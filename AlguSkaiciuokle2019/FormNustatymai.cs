using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlguSkaiciuokle2019
{
    public partial class FormNustatymai : Form
    {
        public FormNustatymai()
        {
            InitializeComponent();
            List<string> mokesciuTarifai = new List<string>();
            try
            {
                using (System.IO.StreamReader reader = new StreamReader("MokesciuTarifai.txt", true))
                {
                    mokesciuTarifai = reader.ReadLine().Split('|').ToList();
                }
                textBoxSveikatosDraudimasPagalSTANDARTINE.Text = mokesciuTarifai[0];
                textBoxPensijuIrSocDraudimasPagalSTANDARTINE.Text = mokesciuTarifai[1];
                textBoxPajamuMokestisPagalSTANDARTINE.Text = mokesciuTarifai[2];
                textBoxDarbdavioMokesciaiPagalSTANDARTINE.Text = mokesciuTarifai[3];
                
                textBoxSveikatosDraudimasAUTORINE.Text = mokesciuTarifai[4];
                textBoxPensijuIrSocDraudimasAUTORINE.Text = mokesciuTarifai[5];
                textBoxPajamuMokestisAUTORINE.Text = mokesciuTarifai[6];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemos nuskaitant failą!");
            }

        }

        private void buttonIssaugoti_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PatikrintiArTikSkaiciai(textBoxPajamuMokestisPagalSTANDARTINE.Text.ToCharArray()))
                {
                    //MessageBox.Show("Patikrinkite įvedamą informaciją. Galima įvesti tik skaičius!");
                    throw new FormatException("Patikrinkite įvedamą informaciją. Galima įvesti tik skaičius!");
                }

                File.WriteAllText("MokesciuTarifai.txt", String.Empty);

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("MokesciuTarifai.txt", true))
                {
                    writer.WriteLine(
                    textBoxSveikatosDraudimasPagalSTANDARTINE.Text + "|" +
                    textBoxPensijuIrSocDraudimasPagalSTANDARTINE.Text + "|" +
                    textBoxPajamuMokestisPagalSTANDARTINE.Text + "|" +
                    textBoxDarbdavioMokesciaiPagalSTANDARTINE.Text + "|" +

                    textBoxSveikatosDraudimasAUTORINE.Text + "|" +
                    textBoxPensijuIrSocDraudimasAUTORINE.Text + "|" +
                    textBoxPajamuMokestisAUTORINE.Text); 
                    writer.Flush(); // Priverst įrašinėt ir išvalyt buferį
                }

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
    }
}
