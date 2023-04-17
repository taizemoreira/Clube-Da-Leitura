using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    class Caixa
    {
        public string Cor { get; set; }
        public string Etiqueta { get; set; }
        public int Numero { get; set; }

        public Caixa(string cor, string etiqueta, int numero)
        {
            Cor = cor;
            Etiqueta = etiqueta;
            Numero = numero;
        }
    }
}
