using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodo
{
    class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNasc;
        public double PosicaoX, PosicaoY;

        public string GetPosicao()
        {
            return PosicaoX + ", " + PosicaoY;
        }

        public void SetPosicao (double x, double y)
        {
            PosicaoX = x;
            PosicaoY = y;
        }
    }
}
