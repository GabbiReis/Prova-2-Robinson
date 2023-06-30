using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDia2
{
    internal class Loja
    {
        private List<Vendedor> vendedores;
        private List<Premio> premios;
        private List<Campanha> campanhas;

        public Loja()
        {
            vendedores = new List<Vendedor>();
            premios = new List<Premio>();
            campanhas = new List<Campanha>();
        }

        public void CadastrarVendedor()
        {
            Console.Clear();
            Console.WriteLine("============ Cadastro de Vendedor ============");
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Vendedor vendedor = new Vendedor()
            {
                CPF = cpf,
                Nome = nome
            };

            vendedores.Add(vendedor);
            Console.WriteLine("Tudo certo! Vendedor cadastrado com sucesso.");
        }

        public void CadastrarPremio()
        {
            Console.Clear();
            Console.WriteLine("============ Cadastro de Prêmio ============");
            Console.Write("Codigo: ");
            string codigo = Console.ReadLine();
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Premio premio = new Premio()
            {
                Codigo = codigo,
                Descricao = descricao
            };

            premios.Add(premio);
            Console.WriteLine("Tudo certo! Prêmio cadastrado com sucesso.");
        }

        public void CadastrarCampanha()
        {
            Console.Clear();
            Console.WriteLine("============ Cadastro de Campanha ============ ");
            Console.Write("Data de Início (dd/mm/aaaa): ");
            DateTime dataDeInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de Fim (dd/mm/aaaa): ");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());
            Console.Write("Campanha: ");
            string campanha = Console.ReadLine();

            Console.WriteLine("Prêmios disponíveis:");
            for (int i = 0; i < premios.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {premios[i].Descricao}");
            }

            Console.Write("Selecione o número do prêmio: ");
            int indicePremio = Convert.ToInt32(Console.ReadLine()) - 1;

            Premio premioSelecionado = premios[indicePremio];

            Campanha novaCampanha = new Campanha()
            {
                DataDeInicio = dataDeInicio,
                DataFim = dataFim,
                Premio = premioSelecionado
            };

            campanhas.Add(novaCampanha);
            Console.WriteLine("Tudo certo! Campanha cadastrada com sucesso.");
        }

        public void PesquisarVendedoresCampanha()
        {
            Console.Clear();
            Console.WriteLine("============  Pesquisa de Vendedores por Campanha ============ ");

            if (campanhas.Count == 0)
            {
                Console.WriteLine("Desculpe! Nenhuma campanha cadastrada.");
                return;
            }

            Console.WriteLine("As campanhas disponíveis são: ");
            for (int i = 0; i < campanhas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {campanhas[i].DataDeInicio:dd/mm/aaaa} até {campanhas[i].DataFim:dd/mm/aaaa}");
            }

            Console.Write("Selecione o número da campanha: ");
            int indiceCampanha = Convert.ToInt32(Console.ReadLine()) - 1;

            Campanha campanhaSelecionada = campanhas[indiceCampanha];

            Console.WriteLine("Os vencedores da campanha forám: ");
            foreach (Vendedor vendedor in campanhaSelecionada.Vendedores)
            {
                Console.WriteLine($"CPF: {vendedor.CPF} | Nome: {vendedor.Nome}");
            }
        }
    }
}
