using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;


            Diretor silvana = new Diretor();
            silvana.Nome = "Silvana";
            silvana.CPF = "546.879.157-20";
            silvana.Salario = 5000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(silvana.Nome);
            Console.WriteLine(silvana.GetBonificacao());

            Console.ReadLine();

        }
    }
}
