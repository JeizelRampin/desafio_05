using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desafio_05
{
    class Program
    {
        static List<Aluno> alunos = new List<Aluno>();
        enum Menu { Adicionar = 1, Sair = 2 }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de alunos - Seja bem vindo!");
                Console.WriteLine("1-Adicionar Alunos\n2-Sair");
                int opInt = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)opInt;

                switch (opcao)
                {
                    case Menu.Adicionar:
                        adicionar();
                        relatorioCSV();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
//-------------------------------------------Adicionar---------------------------------------
        static void adicionar() //função adicionar na List
        {
            Console.Clear();
            Console.WriteLine("======== Adicionar 3 Alunos em LIST! ========");
            int i = 0, contAluno = 1;
            double totalNotas = 0;
            while (i < 3)
            {
                Console.WriteLine("Adicionar aluno: " + contAluno);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Nota: ");
                double nota = float.Parse(Console.ReadLine());
                alunos.Add(new Aluno(nome, idade, nota));
                Console.WriteLine("---------------------------------------------");
                totalNotas += alunos[i].nota;
                i++;
                contAluno++;
            }
            Console.WriteLine("Os 3 ALunos já foram Adicionados na List...");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("A Soma das notas é: " + totalNotas);
        }
//----------------------------------------excel.CSV------------------------------------
        static void relatorioCSV()
        {
            StreamWriter escritor = new StreamWriter("relatorio.csv");
            double totalNotas = 0;
            escritor.WriteLine("Nome" + ";" + "Idade" + ";" + "Nota") ;
            foreach(Aluno aluno in alunos)
            {
                escritor.WriteLine($"{aluno.nome}" + ";" + $"{aluno.idade}" + ";" + $"{aluno.nota}");
                totalNotas += aluno.nota;
            }
            escritor.WriteLine(" " + ";" + "Total" + ";" + "=soma(L[-3]C:L[-1]C)" );
            Console.WriteLine("Relatório CSV foi gerado!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Precione Enter Para voltar ao inicio...");
            Console.ReadLine();

            escritor.Close(); //sempre deve ser fechado no final
            
        }
    }
}
