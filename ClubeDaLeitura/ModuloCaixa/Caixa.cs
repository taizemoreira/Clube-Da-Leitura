using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClubeDaLeitura.ModuloCaixa.Program;
using static ClubeDaLeitura.ModuloCaixa.RepositorioCaixa;

namespace ClubeDaLeitura.ModuloCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa.caixa = new Caixa();
            caixa.id = 1;
            caixa.etiqueta = "abc-123";
            caixa.cor = "vermelha";

            RepositorioCaixa.Inserir(caixa);

            TelaCaixa.MostrarCaixas();

            Console.ReadLine();
        }
    }
   
    public class TelaCaixa
    {
        public static void MostrarCaixas()
        {
            ArrayList caixas = RepositorioCaixa.SelecionarTodos();

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine(caixa.id + ", "
                    + caixa.cor + ", " + caixa.etiqueta);
            }
        }
    }

    public class RepositorioCaixa
    {
        private static ArrayList listaCaixas = new ArrayList();

        public static ArrayList SelecionarTodos()
        {
            ArrayList listaOrdenadaPelaCor = OrdenarLista();
            return listaOrdenadaPelaCor;
        }
        private static void Inserir(Caixa caixa)
        {
            listaCaixas.Add(caixa);
        }
        private static ArrayList OrdenarLista()
        
            return listaCaixas;
        }
        public class Caixa
        {
            public int id; //numero
            public string cor;
            public string etiqueta;

            public int altura;
            public int largura;
            public string material;
            public decimal peso;

            public bool tampaAberta = false;

            public void AbrirTampa()
            {
                tampaAberta = true;
            }
        }
    }
    public class Caixa
    {

    }
    public class Revista
    {
        public string titulo;
        public int ano;
        public Caixa caixa;
    }
}


//        public void Cadastrar()
//        {
//            // Lógica para cadastrar uma nova caixa na camada de acesso a dados.
//        }

//        public void Atualizar()
//        {
//            // Lógica para atualizar uma caixa existente na camada de acesso a dados.
//        }

//        public void Excluir()
//        {
//            // Lógica para excluir uma caixa existente na camada de acesso a dados.
//        }
//    }

//}
