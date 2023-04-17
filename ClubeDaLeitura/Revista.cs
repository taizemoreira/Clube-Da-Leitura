using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    class Revista
    {
        public string TipoColecao { get; set; }
        public int NumeroEdicao { get; set; }
        public int Ano { get; set; }
        public Caixa Caixa { get; set; }

        public Revista(string tipoColecao, int numeroEdicao, int ano, Caixa caixa)
        {
            TipoColecao = tipoColecao;
            NumeroEdicao = numeroEdicao;
            Ano = ano;
            Caixa = caixa;
        }

        public override string ToString()
        {
            return string.Format("{0} - Edição {1}/{2}", TipoColecao, NumeroEdicao, Ano);
        }
    }
}
