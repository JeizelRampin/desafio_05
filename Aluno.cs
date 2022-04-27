using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_05
{
    class Aluno
    {
        public string nome;
        public int idade;
        public double nota;

        public Aluno(string nome, int idade, double nota)
        {
            this.nome = nome;
            this.idade = idade;
            this.nota = nota;
        }
    }
}
