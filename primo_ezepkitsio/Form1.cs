using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primo_ezepkitsio
{
    public partial class Form1 : Form
    {
        List<CProdotto> tutto = new List<CProdotto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CProdotto pNuovo = new CProdotto(txt_nome.Text, float.Parse(txt_prezzo.Text), int.Parse(txt_quantita.Text));
            tutto.Add(pNuovo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_visualizza_Click(object sender, EventArgs e)
        {
            string stampa = "";

            for(int i = 0; i<tutto.Count; i++)
            {
                stampa += tutto.ElementAt(i).Visualizza();
            }

            MessageBox.Show(stampa);
        }

        private void btn_filtra_Click(object sender, EventArgs e)
        {

        }
    }
}
