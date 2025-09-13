using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                                              //W speed
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primo_ezepkitsio
{
    public partial class Aggiungi : Form
    {
        List<CProdotto> tutto = new List<CProdotto>();
        public Aggiungi()
        {
            InitializeComponent();
        }

        private void Aggiungi_Load(object sender, EventArgs e)
        {

        }

        private void btn_aggiungi1_Click(object sender, EventArgs e)
        {
            Form1 aggiungi = new Form1();
            aggiungi.ShowDialog();

            if(aggiungi.DialogResult == DialogResult.OK)
            {
                tutto.Add(aggiungi.PProdotto);
            }
        }

        private void btn_visualizza_Click(object sender, EventArgs e)
        {
            string stampa = "";

            if(tutto.Count == 0)
            {
                MessageBox.Show("Nessun prodotto inserito.");
                return;
            }

            for (int i = 0; i < tutto.Count; i++)
            {
                stampa += tutto.ElementAt(i).Visualizza();
            }

            MessageBox.Show(stampa);
        }

        private void btn_filtra_Click(object sender, EventArgs e)
        {
            float filtro;
            string stampa = "";
            if (float.TryParse(txt_filtro.Text, out filtro))
            {
                for (int i = 0; i < tutto.Count; i++)
                {
                    CProdotto prodotto = tutto.ElementAt(i);
                    if (prodotto.Prezzo <= filtro)
                    {
                        stampa += prodotto.Visualizza();
                    }
                }
                MessageBox.Show(stampa);
            }
            else
            {
                MessageBox.Show("Filtro non valido.");
            }
        }
    }
}
