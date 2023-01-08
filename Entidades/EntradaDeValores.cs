using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comissao.Entidades
{
    public class CalcularComissao
    {
        public void EntradaDeValores()
        {
            Console.WriteLine("#######################################\n");
            Console.WriteLine("######### CALCULO DE COMISSAO #########\n");
            Console.WriteLine("#######################################\n");
            Console.Write("\nDigite o nome do vendedor: ");
            string vendedor = Console.ReadLine();
            Console.Write($"\nQual o valor do salário do vendedor {vendedor}?: R$ ");
            var salario = Convert.ToDouble(Console.ReadLine());
            Console.Write($"\nQual o valor total de vendas realizadas no mês pelo vendedor {vendedor}? R$: ");
            var vendas = Convert.ToDouble(Console.ReadLine());

            var validado = Validacao(vendedor, salario, vendas);

            if (validado == false)
            {
                Console.WriteLine("######### ERROR #########");
                Console.WriteLine("    Tente novamente!");
            }
            Comissao(vendedor, salario, vendas);
        }

        public bool Validacao(string vendedor, double salario, double vendas)
        {
            if (vendedor == null)
            {
                Console.WriteLine("\nNome inválido!");
                return false;
            }
            else if (salario <= 0 || vendas <= 0)
            {
                Console.WriteLine("\nValor inválido!");
                return false;
            }
            return true;
        }

        public void Comissao(string vendedor, double salario, double vendas)
        {
            double comissaoVendas = vendas * 0.15;
            double salarioComissionado = salario + comissaoVendas;
            Console.WriteLine($"\nO salário base do {vendedor} é: R$ {salario.ToString("C2")}. \nValor de comissão: R$ {comissaoVendas.ToString("C2")}. \nValor do salário comissionado: R$ {salarioComissionado.ToString("C2")}");

        }
    }
}
