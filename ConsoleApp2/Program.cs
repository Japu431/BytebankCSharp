using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123 , 871236);     
            Cliente cliente = new Cliente();

            cliente.nome = "Matheus";
            cliente.CPF = "432.433.312-12";
            cliente.profissao = "Dev C#";

            conta.Titular = cliente;

            ContaCorrente contaDaGabriela = new ContaCorrente(123 , 12236);     
            Cliente clienteGabriela = new Cliente();

            clienteGabriela.nome = "Gabriela";
            clienteGabriela.CPF = "432.433.312-12";
            clienteGabriela.profissao = "Dev Js";

            contaDaGabriela.Titular = cliente;

            Console.WriteLine(ContaCorrente.TotalDeContas);
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
         
            Console.ReadLine();
        }
    }
}
