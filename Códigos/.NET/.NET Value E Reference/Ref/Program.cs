class Ref
{
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static void Main(string[] args)
    {
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

        System.Console.WriteLine($@"A lista de nomes Alterada é:
        {string.Join(", ", nomes)}
        ");

        System.Console.WriteLine("Digite o nome a ser substituido");
        var nome = System.Console.ReadLine();
        System.Console.WriteLine("Digite o nome novo");
        var nomeNovo = System.Console.ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        System.Console.WriteLine($@"A lista de nomes Alterada é:
        {string.Join(", ", nomes)}
        ");
    }

    /*
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);

        System.Console.WriteLine($"O valor de a é {a}");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    */
}