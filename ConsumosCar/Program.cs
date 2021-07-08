using System;
using System.Collections.Generic;

namespace ConsumosCar
{
    class Program
    {
        static List<Automoveis> listAutomoveis = new List<Automoveis>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarVeiculos();
						break;
					case "2":
						InserirVeiculo();
						break;
					case "3":
						Autonomia();
						break;
					case "4":
						AluguelPreco();
						break;
				    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Sistema de inserção de veículos a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1- Listar veículos");
			Console.WriteLine("2- Inserir veículo");
			Console.WriteLine("3- Automonia de viagem");
			Console.WriteLine("4- Aluguel/Custo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

		private static void InserirVeiculo()
		{
			Console.WriteLine("Inserir veículo");

			Console.Write("Digite 1 para Álcool, 2 para Gasolina ou 3 para Flex : ");
			int entradaTipoCombustivel = int.Parse(Console.ReadLine());

			Console.Write("Digite o modelo do veículo: ");
			string entradaModelo = Console.ReadLine();

			Console.Write($"Digite o consumo km/l : ");
			double entradaConsumo = double.Parse(Console.ReadLine());

			Console.Write("Digite a capacidade do tanque em litros: ");
			int entradaTanque = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor de 1h de aluguel em R$: ");
			double entradaAluguel = double.Parse(Console.ReadLine());

			Automoveis novoAutomovel = new Automoveis(combustivel: (Combustivel)entradaTipoCombustivel,
										modelo: entradaModelo,
										consumo: entradaConsumo,
										tanque: entradaTanque,
										aluguel: entradaAluguel);

			listAutomoveis.Add(novoAutomovel);
		}

		private static void ListarVeiculos()
		{
			Console.WriteLine("Lista de veículos:");

			if (listAutomoveis.Count == 0)
			{
				Console.WriteLine("Nenhuma veículo cadastrado!");
				return;
			}

			for (int i = 0; i < listAutomoveis.Count; i++)
			{
				Automoveis automovel = listAutomoveis[i];
				Console.Write("ID#{0} - ", i+1);
				Console.WriteLine(automovel);
			}
		}

		private static void Autonomia()
		{
			Console.Write("Digite o id do veiculo: ");
			int idVeiculo = int.Parse(Console.ReadLine());
			
			listAutomoveis[idVeiculo-1].Autonomia();   
		}

		private static void AluguelPreco()
		{
			Console.Write("Digite o id do veiculo: ");
			int idVeiculo = int.Parse(Console.ReadLine());
			
			Console.Write("Digite quantas horas: ");
			int hora = int.Parse(Console.ReadLine());
			
			listAutomoveis[idVeiculo-1].AluguelPreco(hora);                
		}
    }
}
