using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primo_ezepkitsio
{
    internal class CProdotto
    {
        string p_nome;
        float p_prezzo;
        int p_quantita;
        public CProdotto()
        {
            p_nome = ""; p_prezzo = 0f; p_quantita = 0;
        }

        public CProdotto(string Nome, float Prezzo, int Quantita)
        {
            p_nome = Nome;  p_prezzo = Prezzo;  p_quantita = Quantita;
        }
        public string Visualizza()
        {
            return "Nome:\t\t" + p_nome +
                "\nPrezzo\t\t" + p_prezzo +
                "\nQuantità\t\t" + p_quantita + "\n\n";
        }

    }
}
