using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Construtores
{
    class Pessoa
    {
        public string Nome;
        public string Sexo;
        DateTime DataNasc;
        double PosicaoX, PosicaoY;

        public Pessoa(string nome, string sexo, DateTime dataNasc, double x, double y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNasc = dataNasc;
            PosicaoX = x;
            PosicaoY = y;
        }
    }
}
