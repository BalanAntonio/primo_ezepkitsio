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
        private CProdotto coso;
        internal CProdotto PProdotto
        {
            get
            {
                return coso;
            }
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a; int b;
            if (float.TryParse(txt_prezzo.Text, out a) && int.TryParse(txt_quantita.Text,out b) && !string.IsNullOrEmpty(txt_nome.Text) && a>0 && b>0)
            {
                coso = new CProdotto(txt_nome.Text, float.Parse(txt_prezzo.Text), int.Parse(txt_quantita.Text));
                MessageBox.Show($"Aggiunto prodotto {txt_nome.Text}");
                DialogResult = DialogResult.OK;     this.Close();
            }
            else
            {
                MessageBox.Show("Campi input non validi.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
        }

        private void btn_visualizza_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_filtra_Click(object sender, EventArgs e)
        {
            
        }
    }
}
