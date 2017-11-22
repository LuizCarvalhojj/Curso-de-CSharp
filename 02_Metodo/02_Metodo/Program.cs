using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.SetPosicao(10.4, 20.6);

            Console.Write("Posiçâo: " + pessoa.GetPosicao());

            Console.ReadKey();
        }
    }
}
