using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Luiz Felipe";
            pessoa.Sexo = "M";
            pessoa.DataNascimento = new DateTime(1996, 11, 06);

            string texto = pessoa.ResumoPessoa();

            Console.Write(texto);

            Console.ReadKey();

        }
    }
}
