using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja();

            while (true)
            {
                Console.WriteLine("====================== MENU =====================");
                Console.WriteLine("1 - CADASTRAR VENDEDOR ");
                Console.WriteLine("2 - CADASTRAR PREMIO");
                Console.WriteLine("3 - CADASTRAR CAMPANHA");
                Console.WriteLine("4 - EXIBIR VENDEDORES");
                Console.WriteLine("5 - SAIR");
                Console.WriteLine("================================================");
                Console.Write("Digite a opção desejada: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        loja.CadastrarVendedor();
                        break;
                    case 2:
                        loja.CadastrarPremio();
                        break;
                    case 3:
                        loja.CadastrarCampanha();
                        break;
                    case 4:
                        loja.PesquisarVendedoresCampanha();
                        break;
                    case 5:
                        Environment.Exit(0);
                        Console.WriteLine("Encerrando...Até Logo!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente digitando uma da opções disponiveis!");
                        break;
                }
            }
        }
    }
}
