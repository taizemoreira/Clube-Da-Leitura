using System;
using System.Collections.Generic;

namespace ClubeDaLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a Lista de Revistas vazia
            List<Revista> revistas = new List<Revista>();

            // Cria a Lista de Amigos vazia
            List<Amigo> amigos = new List<Amigo>();

            // Cria a Lista de Empréstimos vazia
            List<Emprestimo> emprestimos = new List<Emprestimo>();

            // Cadastro de Revistas
            Caixa caixa1 = new Caixa("Vermelha", "A1", 140);
            Revista revista1 = new Revista("Veja", 1, 2023, caixa1);
            Caixa caixa2 = new Caixa("Preta", "B2", 166);
            Revista revista2 = new Revista("ISTOÉ", 2, 2023, caixa2);
            revistas.Add(revista1);
            revistas.Add(revista2);

            // Cadastro de Amigos
            Amigo amigo1 = new Amigo("João", "Pedro", "49994853610", "Rua Sebastião Gonçalves, 123");
            Amigo amigo2 = new Amigo("Maria", "Betina", "49998544023", "Av. Marechal Deodoro, 456");
            amigos.Add(amigo1);
            amigos.Add(amigo2);

            // Cadastro de Empréstimo
            DateTime dataAtual = DateTime.Now;
            DateTime dataDaquiA7Dias = dataAtual.AddDays(7);
            Emprestimo emprestimo1 = new Emprestimo(amigo1, revista1, dataAtual, dataDaquiA7Dias);
            Emprestimo emprestimo2 = new Emprestimo(amigo2, revista2, dataAtual, null);
            emprestimos.Add(emprestimo1);
            emprestimos.Add(emprestimo2);

            // Percorre todos os empréstimos cadastrados
            foreach (Emprestimo emprestimo in emprestimos)
            {
                //Verifica se algum empréstimo não possui data de devolução
                if (emprestimo.DataDevolucao == null)
                {
                    Console.WriteLine("Empréstimo em aberto: Amigo(a) {0} pegou a revista {1} em {2}",
                        emprestimo.Amigo.Nome, emprestimo.Revista.ToString(), emprestimo.DataEmprestimo.ToShortDateString());
                }
                else
                {
                    Console.WriteLine("Empréstimo realizado: Amigo(a) {0} pegou a revista {1} e precisa devolver em 7 dias",
                        emprestimo.Amigo.Nome, emprestimo.Revista.ToString(), emprestimo.DataEmprestimo.ToShortDateString());
                }
            }

            //Finaliza o sistema pressionando a tecla enter
            Console.ReadLine();
        }
    }
}
