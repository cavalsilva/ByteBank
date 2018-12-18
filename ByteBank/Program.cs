using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario ricardo = new Funcionario();

            ricardo.Nome = "Ricardo";
            ricardo.CPF = "012.234.567-06";
            ricardo.Salario = 2000.00;
            gerenciador.Registrar(ricardo);

            Diretor jakeline = new Diretor();

            jakeline.Nome = "Jakeline";
            jakeline.CPF = "087.789.456-08";
            jakeline.Salario = 5000.00;
            gerenciador.Registrar(jakeline);

            Console.WriteLine(ricardo.Nome);
            Console.WriteLine(ricardo.GetBonificacao());

            Console.WriteLine(jakeline.Nome);
            Console.WriteLine(jakeline.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
