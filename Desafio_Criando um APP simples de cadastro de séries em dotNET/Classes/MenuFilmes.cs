namespace DIO.Series_Filmes
{
    public static class MenuFilmes
    {
        static FilmesRepositorio repositorio = new FilmesRepositorio();
        public static void OpcoesFilmes(){

            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarFilmes();
						break;
					case "2":
						InserirFilme();
						break;
					case "3":
						AtualizarFilme();
						break;
					case "4":
						ExcluirFilme();
						break;
					case "5":
						VisualizarFilme();
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

        private static void ListarFilmes(){
            Console.Write("Lista de Filmes: ");
			Console.WriteLine(" ");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrado.");
				return;
			}

			foreach (var filme in lista)
			{
                var excluido = filme.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "**Excluído**" : ""));
			}
        }


        private static void InserirFilme(){
			Console.WriteLine("======================");
            Console.WriteLine("= Inserir novo filme =");
			Console.WriteLine("======================");
			Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.WriteLine();
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o título do filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o ano do filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a descrição do filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme novoFilme = new Filme(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novoFilme);
        }

        private static void AtualizarFilme()
		{
			Console.Write("Digite o id do filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());
			Console.WriteLine();
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.WriteLine();
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o título do filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o ano do filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a descrição do filme: ");
			string entradaDescricao = Console.ReadLine();

			Filme atualizaFilme = new Filme(id: indiceFilme,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceFilme, atualizaFilme);
		
        }

        private static void ExcluirFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceFilme);
		}

        private static void VisualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorio.RetornaPorId(indiceFilme);

			Console.WriteLine(filme);
		}
        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
            Console.WriteLine("################");
            Console.WriteLine("## DIO Filmes ##");
            Console.WriteLine("################");
            Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:" + Environment.NewLine);

			Console.WriteLine("1- Listar Filmes");
			Console.WriteLine("2- Inserir Novo Filme");
			Console.WriteLine("3- Atualizar Filme");
			Console.WriteLine("4- Excluir Filme");
			Console.WriteLine("5- Visualizar Filme");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;

        }
    }
}