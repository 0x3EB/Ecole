using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1 : Form
    {

        double TauxM, taux, ResuM, ResuTot, duree, montant, dureeCalc = 0.0;
        string ResultatMensu, ResultatTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            duree = double.Parse(textBox2.Text);
            montant = double.Parse(textBox1.Text);
            taux = double.Parse(textBox3.Text);
            dureeCalc = duree * -1;
            TauxM = (taux/100)/12;
            ResuM = (montant *TauxM)/ (1 - Math.Pow(1 + TauxM, dureeCalc));
            ResuM = Math.Round(ResuM, 2);
            ResuTot = ResuM * duree;
            ResultatMensu = ResuM.ToString();
            ResultatTotal = ResuTot.ToString();
            label4.Text = "Montant de la mensualité : " + ResultatMensu + " € ";
            label5.Text = "Coût total de ce crédit : "+ResultatTotal+" €";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num = 0;
            string val = "";
            duree = double.Parse(textBox2.Text);
            montant = double.Parse(textBox1.Text);
            taux = double.Parse(textBox3.Text);
            for (int i=1;i<duree+1;i++)
            {
                val = i.ToString();
                dataGridView1.Rows[i].Cells[1].Value = "i";
            }
        }
    }
}
