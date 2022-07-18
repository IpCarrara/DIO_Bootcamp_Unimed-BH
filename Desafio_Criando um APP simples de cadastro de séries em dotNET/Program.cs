namespace DIO.Series_Filmes
{

    class Program {

        string opcaoUsuarioMenuInicial = ObterOpcaoUsuarioMenuInicial();

        static void Main(string[] args)
        {
            Console.Clear();
            string opcaoUsuarioMenuInicial = ObterOpcaoUsuarioMenuInicial();

            while (opcaoUsuarioMenuInicial.ToUpper() != "X")
            {
                switch (opcaoUsuarioMenuInicial)
                {
                    case "1":
                        //Series;
                        MenuSeries.OpcoesSeries();
                        break;
                    case "2":
                        //Filmes;
                        MenuFilmes.OpcoesFilmes();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuarioMenuInicial = ObterOpcaoUsuarioMenuInicial();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        //Pronto


        private static string ObterOpcaoUsuarioMenuInicial()
        {
            Console.WriteLine();
            Console.WriteLine("#########################################");
            Console.WriteLine("## DIO Séries & Filmes a seu dispor!!! ##");
            Console.WriteLine("#########################################");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:" + Environment.NewLine);
            Console.WriteLine("1- Séries");
            Console.WriteLine("2- Filmes");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuarioMenuInicial = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuarioMenuInicial;
        }

    }
}
